using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Admins;

public class ListAdminsResponse : BaseResponse
{
    public List<AdminUserResponse> Admins { get; set; }
}
