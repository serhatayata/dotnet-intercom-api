namespace DotnetIntercomAPI.Models.Conversations;

public class ConversationPart
{
    public string Type { get; set; }
    public string Id { get; set; }
    public string PartType { get; set; }
    public string Body { get; set; }
    public int CreatedAt { get; set; }
    public int UpdatedAt { get; set; }
    public int NotifiedAt { get; set; }
    public IntercomAssignee AssignedTo { get; set; }
    public IntercomAuthor Author { get; set; }
    public List<IntercomAttachment> Attachments { get; set; }
    public string ExternalId { get; set; }
    public bool Redacted { get; set; }
}
