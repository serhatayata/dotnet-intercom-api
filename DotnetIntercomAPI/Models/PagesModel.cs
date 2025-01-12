using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models;

public class PagesModel
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("next")]
    public NextPageModel Next { get; set; }

    [JsonProperty("page")]
    public int Page { get; set; }

    [JsonProperty("per_page")]
    public int PerPage { get; set; }

    [JsonProperty("total_pages")]
    public int TotalPages { get; set; }
}
