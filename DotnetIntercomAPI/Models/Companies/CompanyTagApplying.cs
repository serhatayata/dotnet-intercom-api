using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Companies;

public class CompanyTagApplying
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }
}
