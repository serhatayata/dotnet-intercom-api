using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models;

public class ErrorModel
{
    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }
}
