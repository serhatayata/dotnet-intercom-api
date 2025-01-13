using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Companies;

public class CompanyTag
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("tags")]
    public List<CompanyTagData> Tags { get; set; }
}
