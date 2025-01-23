using DotnetIntercomAPI.Models.BaseModels;

namespace DotnetIntercomAPI.Responses.Tickets;

public class TicketReplyResponse : BaseResponse
{
    public string Id { get; set; }
    public string PartType { get; set; }
    public string Body { get; set; }
    public string PreviousTicketState { get; set; }
    public int CreatedAt { get; set; }
    public int UpdatedAt { get; set; }
    public IntercomAuthor Author { get; set; }
    public List<IntercomAttachment> Attachments { get; set; }
    public bool Redacted { get; set; }
}
