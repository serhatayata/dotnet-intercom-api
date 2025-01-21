using DotnetIntercomAPI.Models.BaseModels;

namespace DotnetIntercomAPI.Models.Conversations;

public class ConversationSource
{
    public string Type { get; set; }
    public string Id { get; set; }
    public string DeliveredAs { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public IntercomAuthor Author { get; set; }
    public List<IntercomAttachment> Attachments { get; set;}
    public string Url { get; set; }
    public bool Redacted { get; set; }
}
