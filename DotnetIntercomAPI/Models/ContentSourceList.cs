namespace DotnetIntercomAPI.Models;

public class ContentSourceList
{
    public string Type { get; set; }
    public int TotalCount { get; set; }
    public List<ContentSource> ContentSources { get; set; }
}
