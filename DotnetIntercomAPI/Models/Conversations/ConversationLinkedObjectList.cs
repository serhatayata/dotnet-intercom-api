namespace DotnetIntercomAPI.Models.Conversations;

public class ConversationLinkedObjectList
{
    public string Type { get; set; }
    public int TotalCount { get; set; }
    public bool HasMore { get; set; }
    public List<ConversationLinkedObject> Data { get; set; }
}
