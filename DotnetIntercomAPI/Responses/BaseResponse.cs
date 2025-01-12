using DotnetIntercomAPI.Models;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses;

public class BaseResponse
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("request_id")]
    public string RequestId { get; set; }

    [JsonProperty("errors")]
    public List<ErrorModel> Errors { get; set; }
}
