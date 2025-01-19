using DotnetIntercomAPI.Models;

namespace DotnetIntercomAPI.Requests.Conversations;

public class ConversationReplyRequest
{
    public string IntercomUserId { get; set; }
    public List<IntercomAttachment> AttachmentFiles { get; set; }
    public string MessageType { get; set; }
    public string Type { get; set; }
    public string Body { get; set; }
    public int CreatedAt { get; set; }
    public List<string> AttachmentUrls { get; set; }
}
