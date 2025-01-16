using DotnetIntercomAPI.Models;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Admins;

public class AdminUserResponse : BaseResponse
{
    public string Type { get; set; }
    public string Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public bool AwayModeEnabled { get; set; }
    public bool AwayModeReassign { get; set; }
    public bool HasInboxSeat { get; set; }
    public List<int> TeamIds { get; set; }
    public IntercomAvatar Avatar { get; set; }
    public TeamPriorityLevel TeamPriorityLevel { get; set; }
}
