using System.Text;
using DotnetIntercomAPI.Requests.Admins;
using DotnetIntercomAPI.Responses.Admins;
using DotnetIntercomAPI.Services.Abstract;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Services.Concrete;

public class IntercomService : IIntercomService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<IntercomService> _logger;

    public IntercomService(
    IHttpClientFactory httpClientFactory,
    ILogger<IntercomService> logger)
    {
        _httpClient = httpClientFactory.CreateClient("intercom");
        _logger = logger;
    }

    #region Admin
    /// <summary>
    /// You can view the currently authorised admin along with the embedded app object 
    /// </summary>
    /// <returns><see cref="IdentifyAdminResponse"/></returns>
    public async Task<IdentifyAdminResponse> IdentifyAdmin()
    {
        try
        {
            return await GetAsync<object, IdentifyAdminResponse>("me");
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can set an Admin as away for the Inbox.
    /// </summary>
    /// <param name="id">id of the admin</param>
    /// <returns><see cref="AdminUserResponse"/></returns>
    public async Task<AdminUserResponse> SetAdminAway(string id)
    {
        try
        {
            return await PutAsync<SetAdminAwayRequest, AdminUserResponse>($"admins/{id}/away", new SetAdminAwayRequest
            {
                AwayModeEnabled = true,
                AwayModeReassign = true
            });
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }
    #endregion


    #region Private Methods
    private async Task<R> GetAsync<T,R>(string endpoint, Dictionary<string, string> parameters = null)
    {
        var response = await _httpClient.GetAsync(endpoint);
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<R>(responseString);

        return result;
    }

    private async Task<R> PostAsync<T,R>(string endpoint, T data) where T : class
    {
        var dataStr = Serialize<T>(data);
        var content = new StringContent(dataStr, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(endpoint, content);
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<R>(responseString);

        return result;
    }

    private async Task<R> PutAsync<T,R>(string endpoint, T data) where T : class
    {
        var dataStr = Serialize<T>(data);
        var content = new StringContent(dataStr, Encoding.UTF8, "application/json");

        var response = await _httpClient.PutAsync(endpoint, content);
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<R>(responseString);

        return result;
    }

    private string Serialize<T>(T data) where T : class
    {
        return JsonConvert.SerializeObject(data, typeof(T), Formatting.None, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        });
    }
    #endregion
}