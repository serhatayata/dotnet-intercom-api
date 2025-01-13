using DotnetIntercomAPI.Models;
using DotnetIntercomAPI.Models.Companies;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Companies;

public class CompanyListResponse : BaseResponse
{
    [JsonProperty("data")]
    public List<CompanyModel> Data { get; set; }

    [JsonProperty("pages")]
    public PagesModel Pages { get; set; }

    [JsonProperty("total_count")]
    public int TotalCount { get; set; }
}
