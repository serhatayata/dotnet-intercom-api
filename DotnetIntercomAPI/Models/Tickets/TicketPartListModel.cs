namespace DotnetIntercomAPI.Models.Tickets;

public class TicketPartListModel
{
    public string Type { get; set; }
    public List<TicketPartModel> TicketParts { get; set; }
    public int TotalCount { get; set; }
}
