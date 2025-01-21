using DotnetIntercomAPI.Models.BaseModels;

namespace DotnetIntercomAPI.Requests.Conversations;

public class ConversationCreateRequest
{
    public IntercomFrom From { get; set; }
    public string Body { get; set; }
}
