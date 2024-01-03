using BackendCore.Lib.Libraries.ApplicationDomain;
using BackendCore.Lib.Services;
using BackendGobiernoIT.Data;
using BackendGobiernoIT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendGobiernoIT.Controllers;

[ApplicationDomain("Core"), Route("api/[controller]"), ApiController, Authorize]
public class CasesController : ControllerBase
{
    private readonly ApplicationDbContext m_DbContext;
    private readonly INotificationService m_NotificationsService;


    public CasesController(ApplicationDbContext dbContext, INotificationService notificationsService)
    {
        m_DbContext = dbContext;
        m_NotificationsService = notificationsService;
    }

    [HttpPut("Start")]
    public async Task<IActionResult> StartCase(int caseId)
    {
        try
        {
            var _case = await AssertAndGetCase(caseId);

            if (_case.StatusId != "CaseStatusNew")
                return Ok($"Only new cases can be started.");

            _case.StatusId = "CaseStatusInProgress";

            await m_DbContext.SaveChangesAsync();

            return Ok();
        }
        catch (Exception ex) 
        { 
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("Pause")]
    public async Task<IActionResult> PauseCase(int caseId)
    {
        try
        {
            var _case = await AssertAndGetCase(caseId);

            if (_case.StatusId == "CaseStatusNew" || _case.StatusId == "CaseStatusClosed")
                return BadRequest($"You can only pause in progress cases.");

            _case.StatusId = "CaseStatusPaused";

            await m_DbContext.SaveChangesAsync();

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("Unpause")]
    public async Task<IActionResult> UnpauseCase(int caseId)
    {
        try
        {
            var _case = await AssertAndGetCase(caseId);

            if (_case.StatusId != "CaseStatusPaused")
                return BadRequest($"You can only unpause paused cases.");

            _case.StatusId = "CaseStatusInProgress";

            await m_DbContext.SaveChangesAsync();

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public class ApiResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }

    [HttpPut("Close")]
    public async Task<IActionResult> CloseCase(int caseId)
    {
        try
        {
            var _case = await AssertAndGetCase(caseId);

            if (!_case.Subtasks.All(k => k.StatusId == "CaseStatusClosed"))
                return Ok(new ApiResponse { Success = false, Message = $"You can close a case once all of its subtasks have been closed." });

            _case.StatusId = "CaseStatusClosed";

            await m_DbContext.SaveChangesAsync();

            return Ok(new ApiResponse { Success = false, Message = $"Case closed properly." });
        }
        catch (Exception ex)
        {
            return Ok(new ApiResponse { Success = false, Message = $"{ex.Message}" });
        }
    }

    [HttpGet("SendFollowUpEmail")]
    public async Task<IActionResult> SendFollowUpEmail(int followUpId)
    {
        try
        {
            var followUp = await m_DbContext.FollowUps
                .Include(k => k.ClientUser)
                    .ThenInclude(e => e.Emails)
                .Where(k => k.Id == followUpId).FirstOrDefaultAsync();
            if (followUp is null)
                return NotFound($"FollowUp with id ${followUpId} not found!");

            if (!followUp.NotifyByEmail || followUp.ClientUser is null) return Ok();
            var clientEmail = followUp.ClientUser.Emails.FirstOrDefault();
            if (clientEmail is null) return Ok();

            await m_NotificationsService.SendToEmailRecipient(
                clientEmail.Email,
                "FOLLOWUP_TECHNICIAN",
                new Dictionary<string, string>()
                {
                    { "SUBJECT", $"#{followUp.CaseId}"},
                    { "PREV_CONTENT", followUp.Description }
                });

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    private async Task<Case> AssertAndGetCase(int caseId) 
    { 
        var kit = await m_DbContext.Cases.Include(k => k.Subtasks).FirstOrDefaultAsync(k => k.Id == caseId);

        if (kit is null)
            throw new Exception($"${caseId} not found!");

        return kit;
    }
}
