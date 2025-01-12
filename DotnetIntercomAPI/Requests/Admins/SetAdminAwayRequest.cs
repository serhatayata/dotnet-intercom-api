using Newtonsoft.Json;

namespace DotnetIntercomAPI.Requests.Admins;

public class SetAdminAwayRequest
{
    [JsonProperty("away_mode_enabled")]
    public bool AwayModeEnabled { get; set; }

    [JsonProperty("away_mode_reassign")]
    public bool AwayModeReassign { get; set; }
}
