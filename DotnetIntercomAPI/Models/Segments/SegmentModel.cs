namespace DotnetIntercomAPI.Models.Segments;

public class SegmentModel
{
    public string Type { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public int CreatedAt { get; set; }
    public int UpdatedAt { get; set; }
    public string PersonType { get; set; }
    public int Count { get; set; }
}
