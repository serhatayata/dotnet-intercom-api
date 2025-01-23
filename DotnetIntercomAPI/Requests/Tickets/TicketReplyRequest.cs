using DotnetIntercomAPI.Models.Tickets;

namespace DotnetIntercomAPI.Requests.Tickets;

public class TicketReplyRequest
{
    public string? IntercomUserId { get; set; }
    public string? UserId { get; set; }
    public string? Email { get; set; }
    public string? AdminId { get; set; }
    public string MessageType { get; set; }
    public string Type { get; set; }
    public string Body { get; set; }
    public int CreatedAt { get; set; }
    public List<TicketReplyOption>? ReplyOptions { get; set; }
    public List<string> AttachmentUrls { get; set; }
}
