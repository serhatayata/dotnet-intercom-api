namespace DotnetIntercomAPI.Models.BaseModels;

public class ActivityLogMetadata
{
    public string Before { get; set; }
    public string After { get; set; }
    public MessageModel Message { get; set; }
}
