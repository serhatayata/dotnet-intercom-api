namespace DotnetIntercomAPI.Models;

public class IntercomAttachment
{
    public string Type { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string ContentType { get; set; }
    public int FileSize { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}
