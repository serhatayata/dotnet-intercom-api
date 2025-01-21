using DotnetIntercomAPI.Models.BaseModels;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Admins;

public class AdminModel
{
    public string Type { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string JobTitle { get; set; }
    public bool AwayModeEnabled { get; set; }
    public bool ArrayModeReassign { get; set; }
    public bool HasInboxSeat { get; set; }
    public List<int> TeamIds { get; set; }
    public string Avatar { get; set; }
    public TeamPriorityLevel TeamPriorityLevel { get; set; }
}
