using Microsoft.Graph;

namespace BackendGobiernoIT.Libs;

public class Exchange
{
    private readonly HttpClient _httpClient;
    private readonly string _apiBaseUrl;

    public Exchange(string apiBaseUrl, HttpClient httpClient)
    {
        _apiBaseUrl = apiBaseUrl;
        _httpClient = httpClient;
    }

    public async Task<List<Microsoft.Graph.Message>> GetEmailsAsync(string userId, bool onlyUnread, int? count = null)
    {
        var response = await _httpClient.GetAsync($"{_apiBaseUrl}/email/exchange/mails?userId={userId}&onlyUnread={onlyUnread}&count={count}");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<List<Microsoft.Graph.Message>>();
        }
        else
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            throw new Exception($"Error retrieving emails: {errorContent}");
        }
    }

    public async Task<bool> SetCheckedAsync(string userId, string messageId)
    {
        // Construct the request URL
        string requestUrl = $"{_apiBaseUrl}/Email/Exchange/markread?userId={userId}&messageId={messageId}";

        // Prepare the request content, if necessary. Some APIs require a body for PUT requests, even if it's empty
        HttpContent content = new StringContent(string.Empty); // Or appropriately construct content if your API requires

        // Make the API call to mark the email as read
        var response = await _httpClient.PutAsync(requestUrl, content);

        // Return true if the operation was successful; otherwise, false
        if (response.IsSuccessStatusCode)
        {
            return true;
        }
        else
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            // Consider logging the error or throwing an exception based on your application's needs
            return false;
        }
    }
}
