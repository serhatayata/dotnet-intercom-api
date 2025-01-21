namespace DotnetIntercomAPI.Requests.DataEvents;

public class DataEventListRequest
{
    public bool Summary { get; set; }
    public string Type { get; set; }
    public string? UserId { get; set; }
    public string? IntercomUserId { get; set; }
    public string? Email { get; set; }
}
