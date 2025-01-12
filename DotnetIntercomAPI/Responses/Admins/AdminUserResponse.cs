using DotnetIntercomAPI.Models;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Admins;

public class AdminUserResponse : BaseResponse
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("away_mode_enabled")]
    public bool AwayModeEnabled { get; set; }

    [JsonProperty("away_mode_reassign")]
    public bool AwayModeReassign { get; set; }

    [JsonProperty("has_inbox_seat")]
    public bool HasInboxSeat { get; set; }

    [JsonProperty("team_ids")]
    public List<int> TeamIds { get; set; }
}
