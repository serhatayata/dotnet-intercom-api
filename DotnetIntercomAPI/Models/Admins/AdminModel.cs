using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Admins;

public class AdminModel
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("job_title")]
    public string JobTitle { get; set; }

    [JsonProperty("away_mode_enabled")]
    public bool AwayModeEnabled { get; set; }

    [JsonProperty("away_mode_reassign")]
    public bool ArrayModeReassign { get; set; }

    [JsonProperty("has_inbox_seat")]
    public bool HasInboxSeat { get; set; }

    [JsonProperty("team_ids")]
    public List<int> TeamIds { get; set; }

    [JsonProperty("avatar")]
    public string Avatar { get; set; }

    [JsonProperty("request_id")]
    public string RequestId { get; set; }

    [JsonProperty("errors")]
    public List<ErrorModel> Errors { get; set; }
}
