using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Companies;

public class CompanyTagData
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("applied_at")]
    public int AppliedAt { get; set; }

    [JsonProperty("applied_by")]
    public CompanyTagApplying AppliedBy { get; set; }
}
