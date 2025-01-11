using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models;

public class TeamPriorityLevel
{
    [JsonProperty("primary_team_ids")]
    public List<int> PrimaryTeamIds { get; set; }

    [JsonProperty("secondary_team_ids")]
    public List<int> SecondaryTeamIds { get; set; }
}
