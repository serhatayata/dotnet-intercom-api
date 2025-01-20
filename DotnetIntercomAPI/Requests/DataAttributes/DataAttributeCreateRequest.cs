namespace DotnetIntercomAPI.Requests.DataAttributes;

public class DataAttributeCreateRequest
{
    public string Name { get; set; }
    public string Model { get; set; }
    public string DataType { get; set; }
    public string Description { get; set; }
    public List<string> Options { get; set; }
    public bool MessengerWritable { get; set; }
}
