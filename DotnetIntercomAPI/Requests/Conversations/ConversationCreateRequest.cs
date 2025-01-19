using DotnetIntercomAPI.Models.Conversations;

namespace DotnetIntercomAPI.Requests.Conversations;

public class ConversationCreateRequest
{
    public ConversationFrom From { get; set; }
    public string Body { get; set; }
}
