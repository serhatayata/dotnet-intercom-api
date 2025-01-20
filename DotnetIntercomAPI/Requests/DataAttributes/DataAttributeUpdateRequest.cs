namespace DotnetIntercomAPI.Requests.DataAttributes;

public class DataAttributeUpdateRequest
{
    public bool Archived { get; set; }
    public string Description { get; set; }
    public List<string> Options { get; set; }
    public bool MessengerWritable { get; set; }
}
