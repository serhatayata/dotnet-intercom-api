using DotnetIntercomAPI.Models.Tickets;

namespace DotnetIntercomAPI.Requests.Tickets;

public class TicketCreateRequest
{
    public string TicketTypeId { get; set; }
    public List<TicketContactModel> Contacts { get; set; }
    public string CompanyId { get; set; }
    public int CreatedAt { get; set; }
    public object TicketAttributes { get; set; }
}
