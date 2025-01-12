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

    #region Admins
    /// <summary>
    /// You can view the currently authorised admin along with the embedded app object 
    /// </summary>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="IdentifyAdminResponse"/></returns>
    public async Task<IdentifyAdminResponse> IdentifyAdmin(
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<IdentifyAdminResponse>(endpoint: "me", 
                                                         parameters: null, 
                                                         cancellationToken: cancellationToken);
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
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="AdminUserResponse"/></returns>
    public async Task<AdminUserResponse> SetAdminAway(
    string id, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await PutAsync<SetAdminAwayRequest, AdminUserResponse>($"admins/{id}/away", new SetAdminAwayRequest
            {
                AwayModeEnabled = true,
                AwayModeReassign = true
            }, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can get a log of activities by all admins
    /// </summary>
    /// <param name="createdAtAfter">create at after</param>
    /// <param name="createdAtBefore">created at before</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ListAllActivityLogsResponse"/></returns>
    public async Task<ListAllActivityLogsResponse> ListAllActivityLogs(
    string createdAtAfter,
    string createdAtBefore,
    CancellationToken cancellationToken = default)
    {
        try
        {
            var parameters = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(createdAtAfter))
                parameters.Add("created_at_after", createdAtAfter);
            if (!string.IsNullOrEmpty(createdAtBefore))
                parameters.Add("created_at_before", createdAtBefore);

            return await GetAsync<ListAllActivityLogsResponse>(endpoint: "admins/activity_logs", 
                                                               parameters: parameters, 
                                                               cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can fetch a list of admins for a given workspace.
    /// </summary>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ListAdminsResponse"/></returns>
    public async Task<ListAdminsResponse> ListAllAdmins(
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<ListAdminsResponse>(endpoint: "admins",
                                                      parameters: null,
                                                      cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can retrieve the details of a single admin.
    /// </summary>
    /// <param name="id">id of admin</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">throws exception if id is null</exception>
    public async Task<AdminUserResponse> RetrieveAdmin(
    string id, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id));

            return await GetAsync<AdminUserResponse>($"admins/{id}",
                                                     parameters: null,
                                                     cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }
    #endregion


    #region Private Methods
    private async Task<R> GetAsync<R>(
    string endpoint, 
    Dictionary<string, string> parameters = null,
    CancellationToken cancellationToken = default)
    {
        if (parameters != null && parameters.Count > 0)
        {
            var queryString = await new FormUrlEncodedContent(parameters).ReadAsStringAsync();
            endpoint = $"{endpoint}?{queryString}";
        }

        var response = await _httpClient.GetAsync(endpoint, cancellationToken);
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<R>(responseString);

        return result;
    }

    private async Task<R> PostAsync<T,R>(
    string endpoint, 
    T data,
    CancellationToken cancellationToken = default) 
    where T : class
    {
        var dataStr = Serialize<T>(data);
        var content = new StringContent(dataStr, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(endpoint, content, cancellationToken);
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<R>(responseString);

        return result;
    }

    private async Task<R> PutAsync<T,R>(
    string endpoint, 
    T data, 
    CancellationToken cancellationToken = default) 
    where T : class
    {
        var dataStr = Serialize<T>(data);
        var content = new StringContent(dataStr, Encoding.UTF8, "application/json");

        var response = await _httpClient.PutAsync(endpoint, content, cancellationToken);
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<R>(responseString);

        return result;
    }

    private string Serialize<T>(
    T data) 
    where T : class
    {
        return JsonConvert.SerializeObject(data, typeof(T), Formatting.None, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        });
    }
    #endregion
}