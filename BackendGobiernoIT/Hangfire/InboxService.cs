using BackendCore.Lib.Configuration;
using BackendCore.Lib.Services;
using BackendGobiernoIT.Data;
using BackendGobiernoIT.Libs;
using BackendGobiernoIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;


namespace BackendGobiernoIT.Hangfire;

public interface IInboxService
{
    Task CheckInbox();
}

public class InboxService : IInboxService
{
    private readonly ApplicationDbContext m_DbContext;
    private readonly ExternalEndpoints m_ExternalEndpoints;
    private readonly INotificationService m_NotificationsService;

    public InboxService(ApplicationDbContext dbContext, IOptions<ExternalEndpoints> _externalEndpoints, INotificationService notificationService)
    {
        m_DbContext = dbContext;
        m_ExternalEndpoints = _externalEndpoints.Value;
        m_NotificationsService = notificationService;
    }

    public async Task CheckInbox()
    {
        // Your logic to check the inbox
        var exchange = new Exchange(m_ExternalEndpoints.apitools, new HttpClient());
        string userId = "8ff0517a-3c9f-4be2-975c-48cdbecd9d49";
        var emails = await exchange.GetEmailsAsync(userId, true);

        // Define the regex pattern to match "## {NUMBER} ##"
        string pattern = @"#(\d+)";
        Regex regex = new Regex(pattern);

        foreach (var email in emails)
        {
            var senderEmail = email.Sender.EmailAddress.Address;
            var senderDomain = senderEmail.Split('@')[1];
            var company = m_DbContext.Companies.Include(k => k.CompanyUsers).Where(k => k.EmailDomains.Any(k => k.DomainName == senderDomain)).FirstOrDefault();
            if (company is null)
                continue;
            
            var requesterClient = m_DbContext.CompanyUsers.Where(u => u.Emails.Any(e => e.Email == senderEmail) && u.CompanyId == company.Id).FirstOrDefault();

            // Check if the email subject matches the pattern
            Match match = regex.Match(email.Subject);
            if (match.Success)
            {
                // Extract the number from the subject
                int caseId = int.Parse(match.Groups[1].Value);

                var caseObj = await m_DbContext.Cases
                        .Include(k => k.Subtasks)
                        .Include(k => k.FollowUps)
                        .Where(k => k.Id == caseId)
                        .FirstOrDefaultAsync();

                if (caseObj is null)
                    continue;

                var content = WebUtility.HtmlDecode(email.Body.Content).Split("<$--ESCRIBE ARRIBA--$>")[0];
                var newFollowUp = new FollowUp();
                newFollowUp.CaseId = caseId;
                newFollowUp.ClientUser = requesterClient;
                newFollowUp.DateTime = DateTime.UtcNow;
                newFollowUp.InternalUserId = "4cda5f8f-a2d9-4780-bb43-92926df99da4";
                newFollowUp.IsPrivate = false;
                newFollowUp.NotifyByEmail = true;
                newFollowUp.Description = content;
                await m_DbContext.FollowUps.AddAsync(newFollowUp);
                await exchange.SetCheckedAsync(userId, email.Id);
                await m_DbContext.SaveChangesAsync();
            }
            else
            {
                    Case newCase = new Case();

                    newCase.CaseDescription = email.Subject;
                    newCase.Notes = email.Body.Content;

                    newCase.Company = company;
                    if (company is null)
                        throw new Exception("Caso sin clasificar!");

                    newCase.RequesterClient = requesterClient;
                    newCase.StatusId = "CaseStatusNew";
                    newCase.PriorityId = "CasePriorityMid";
                    newCase.EntryChannelId = "CaseEntryChannelEmail";
                    newCase.CreatorUserId = "4cda5f8f-a2d9-4780-bb43-92926df99da4";
                    await m_DbContext.Cases.AddAsync(newCase);
                    await m_DbContext.SaveChangesAsync();
                    await exchange.SetCheckedAsync(userId, email.Id);
                    await m_NotificationsService.SendToEmailRecipient(
                        senderEmail,
                        "NEW_CASE_CLIENT",
                        new Dictionary<string, string>()
                        {
                                {"CASE_ID", newCase.Id.ToString() },

                        });
            }
        }
    }
}
