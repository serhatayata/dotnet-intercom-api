using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Companies;

public class CompanyPlan
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}
