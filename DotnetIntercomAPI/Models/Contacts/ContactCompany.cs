using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Contacts;

public class ContactCompany
{
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("total_count")]
    public string TotalCount { get; set; }

    [JsonProperty("has_more")]
    public string HasMore { get; set; }
}
