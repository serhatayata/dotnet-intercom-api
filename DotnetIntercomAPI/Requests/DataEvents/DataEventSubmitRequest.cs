namespace DotnetIntercomAPI.Requests.DataEvents;

public class DataEventSubmitRequest
{
    public string EventName { get; set; }
    public int CreatedAt { get; set; }
    public string? UserId { get; set; }
    public string? Id { get; set; }
    public string? Email { get; set; }
    public object Metadata { get; set; }
}
