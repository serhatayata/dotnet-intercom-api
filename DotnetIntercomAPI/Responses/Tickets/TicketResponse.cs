using DotnetIntercomAPI.Models.BaseModels;
using DotnetIntercomAPI.Models.Contacts;
using DotnetIntercomAPI.Models.Tickets;
using DotnetIntercomAPI.Models.TicketTypes;

namespace DotnetIntercomAPI.Responses.Tickets;

public class TicketResponse : BaseResponse
{
    public string Id { get; set; }
    public string TicketId { get; set; }
    public string Category { get; set; }
    public object TicketAttributes { get; set; }
    public string TicketState { get; set; }
    public TicketTypeModel TicketType { get; set; }
    public ContactReferenceList Contacts { get; set; }
    public string AdminAssigneeId { get; set; }
    public string TeamAssigneeId { get; set; }
    public int CreatedAt { get; set; }
    public int UpdatedAt { get; set; }
    public bool Open { get; set; }
    public int SnoozedUntil { get; set; }
    public LinkedObjectList LinkedObjects { get; set; }
    public TicketPartListModel TicketParts { get; set; }
    public bool IsShared { get; set; }
    public string TicketStateInternalLabel { get; set; }
    public string TicketStateExternalLabel { get; set; }
}
