using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models;

public class NextPageModel
{
    [JsonProperty("per_page")]
    public int PerPage { get; set; }

    [JsonProperty("starting_after")]
    public string StartingAfter { get; set; }
}
