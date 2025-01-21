using DotnetIntercomAPI.Models.BaseModels;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Admins;

public class IdentifyAdminResponse : BaseResponse
{    public string Type { get; set; }
    public string Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public bool EmailVerified { get; set; }
    public IntercomAppModel App { get; set; }
    public IntercomAvatar Avatar { get; set; }
    public bool HasInboxSeat { get; set; }
}
