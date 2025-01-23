using DotnetIntercomAPI.Models.Tickets;

namespace DotnetIntercomAPI.Requests.Tickets;

public class TicketUpdateRequest
{
    public object TicketAttributes { get; set; }
    public string State { get; set; }
    public bool Open { get; set; }
    public bool IsShared { get; set; }
    public int SnoozedUntil { get; set; }
    public TicketAssignmentModel Assignment { get; set; }
}
