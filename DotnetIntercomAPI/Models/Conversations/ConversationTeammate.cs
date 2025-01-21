using DotnetIntercomAPI.Models.BaseModels;

namespace DotnetIntercomAPI.Models.Conversations;

public class ConversationTeammate
{
    public string Type { get; set; }
    public List<IntercomTeammate> Teammates { get; set; }
}
