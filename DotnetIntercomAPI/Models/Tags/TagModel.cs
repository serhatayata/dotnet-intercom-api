namespace DotnetIntercomAPI.Models.Tags;

public class TagModel
{
    public string Type { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public int AppliedAt { get; set; }
    public TagApplying AppliedBy { get; set; }
}
