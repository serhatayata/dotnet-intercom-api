using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models;

public class MessageModel
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }
}
