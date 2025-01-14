using DotnetIntercomAPI.Models;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Requests;

public class PagesRequest
{
    [JsonProperty("type")]
    public string? Type { get; set; }

    [JsonProperty("next")]
    public NextPageModel? Next { get; set; }

    [JsonProperty("page")]
    public int? Page { get; set; }

    [JsonProperty("per_page")]
    public int? PerPage { get; set; }

    [JsonProperty("total_pages")]
    public int? TotalPages { get; set; }

    [JsonProperty("order")]
    public string? Order { get; set; }
}
