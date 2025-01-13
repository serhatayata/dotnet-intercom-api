using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models;

public class IntercomLocationModel
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("region")]
    public string Region { get; set; }

    [JsonProperty("city")]
    public string City { get; set; }
}
