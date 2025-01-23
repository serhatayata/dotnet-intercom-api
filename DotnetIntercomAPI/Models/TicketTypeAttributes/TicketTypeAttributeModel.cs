using DotnetIntercomAPI.Models.BaseModels;

namespace DotnetIntercomAPI.Models.TicketTypeAttributes;

public class TicketTypeAttributeModel
{
    public string Type { get; set; }
    public string Id { get; set; }
    public string WorkspaceId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string DataType { get; set; }
    public InputOptions InputOptions { get; set; }
    public int Order { get; set; }
    public bool RequiredToCreate { get; set; }
    public bool RequiredToCreateForContacts { get; set; }
    public bool VisibleOnCreate { get; set; }
    public bool VisibleToContacts { get; set; }
    public bool Default { get; set; }
    public int TicketTypeId { get; set; }
    public bool Archived { get; set; }
    public int CreatedAt { get; set; }
    public int UpdatedAt { get; set; }
}
