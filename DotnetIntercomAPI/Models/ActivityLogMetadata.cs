using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models;

public class ActivityLogMetadata
{
    [JsonProperty("before")]
    public string Before { get; set; }

    [JsonProperty("after")]
    public string After { get; set; }

    [JsonProperty("message")]
    public MessageModel Message { get; set; }
}
