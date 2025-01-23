namespace DotnetIntercomAPI.Models.BaseModels;

public class LinkedObjectList
{
    public string Type { get; set; }
    public int TotalCount { get; set; }
    public bool HasMore { get; set; }
    public List<LinkedObject> Data { get; set; }
}
