using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Contacts;

public class ContactSocialProfileData
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}
