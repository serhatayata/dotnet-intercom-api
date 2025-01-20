namespace DotnetIntercomAPI.Models.DataAttributes;

public class DataAttributeModel
{
    public string Type { get; set; }
    public int Id { get; set; }
    public string Model { get; set; }
    public string Name { get; set; }
    public string FullName { get; set; }
    public string Label { get; set; }
    public string Description { get; set; }
    public string DataType { get; set; }
    public List<string> Options { get; set; }
    public bool ApiWritable { get; set; }
    public bool MessengerWritable { get; set; }
    public bool UiWritable { get; set; }
    public bool Custom { get; set; }
    public bool Archived { get; set; }
    public int CreatedAt { get; set; }
    public int UpdatedAt { get; set; }
    public string AdminId { get; set; }
}
