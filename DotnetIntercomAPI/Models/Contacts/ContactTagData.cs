using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Contacts;

public class ContactTagData
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}
