namespace DotnetIntercomAPI.Requests.Conversations;

public class ConversationUpdateRequest
{
    public bool Read { get; set; }
    public object CustomAttributes { get; set; }
}
