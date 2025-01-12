using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Admins;

public class ListAdminsResponse : BaseResponse
{
    [JsonProperty("admins")]
    public List<AdminUserResponse> Admins { get; set; }
}
