namespace DotnetIntercomAPI.Requests.DataAttributes;

public class DataAttributeListRequest
{
    public bool IncludeArchived { get; set; }
    public string Model { get; set; }
}
