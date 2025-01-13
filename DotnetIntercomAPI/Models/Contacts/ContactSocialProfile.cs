using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Contacts;

public class ContactSocialProfile
{
    [JsonProperty("data")]
    public List<ContactSocialProfileData> Data { get; set; }
}
