namespace DotnetIntercomAPI.Requests.TicketTypes;

public class TicketTypeUpdateRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string Icon { get; set; }
    public bool Archived { get; set; }
    public bool IsInternal { get; set; }
}
