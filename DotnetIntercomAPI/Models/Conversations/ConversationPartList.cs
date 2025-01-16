namespace DotnetIntercomAPI.Models.Conversations;

public class ConversationPartList
{
    public string Type { get; set; }
    public ConversationPart ConversationParts { get; set; }
    public int TotalCount { get; set; }
}
