using DotnetIntercomAPI.Models;
using DotnetIntercomAPI.Models.Contacts;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Contacts;

public class ContactListResponse : BaseResponse
{
    [JsonProperty("data")]
    public List<ContactModel> Data { get; set; }

    [JsonProperty("total_count")]
    public int TotalCount { get; set; }

    [JsonProperty("pages")]
    public PagesModel Pages { get; set; }
}
