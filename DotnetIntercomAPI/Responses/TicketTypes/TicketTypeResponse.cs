using DotnetIntercomAPI.Models.TicketTypeAttributes;

namespace DotnetIntercomAPI.Responses.TicketTypes;

public class TicketTypeResponse : BaseResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
    public string WorkspaceId { get; set; }
    public bool Archived { get; set; }
    public int CreatedAt { get; set; }
    public int UpdatedAt { get; set; }
    public bool IsInternal { get; set; }
    public List<TicketTypeAttributeListModel> TicketTypeAttributes { get; set; }
    public string Category { get; set; }
}
