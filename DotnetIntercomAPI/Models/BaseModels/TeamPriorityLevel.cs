namespace DotnetIntercomAPI.Models.BaseModels;

public class TeamPriorityLevel
{
    public List<int> PrimaryTeamIds { get; set; }
    public List<int> SecondaryTeamIds { get; set; }
}
