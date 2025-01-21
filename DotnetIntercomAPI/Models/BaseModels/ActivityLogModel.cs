namespace DotnetIntercomAPI.Models.BaseModels;

public class ActivityLogModel
{
    public string Id { get; set; }
    public UserModel PerformedBy { get; set; }
    public ActivityLogMetadata Metadata { get; set; }
    public long CreatedAt { get; set; }
    public string ActivityType { get; set; }
    public string ActivityDescription { get; set; }
}
