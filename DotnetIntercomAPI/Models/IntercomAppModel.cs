using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models;

public class IntercomAppModel
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id_code")]
    public string IdCode { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("created_at")]
    public long CreatedAt { get; set; }

    [JsonProperty("secure")]
    public bool Secure { get; set; }

    [JsonProperty("identity_verification")]
    public bool IdentityVerification { get; set; }

    [JsonProperty("timezone")]
    public string TimeZone { get; set; }

    [JsonProperty("region")]
    public string Region { get; set; }
}
