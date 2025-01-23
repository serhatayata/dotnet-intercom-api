namespace DotnetIntercomAPI.Models.TicketTypeAttributes;

public class TicketTypeAttributeListModel
{
    public string Type { get; set; }
    public List<TicketTypeAttributeModel> Data { get; set; }
}
