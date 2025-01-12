using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models;

public class ActivityLogModel
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("performed_by")]
    public UserModel PerformedBy { get; set; }

    [JsonProperty("metadata")]
    public ActivityLogMetadata Metadata { get; set; }

    [JsonProperty("created_at")]
    public long CreatedAt { get; set; }

    [JsonProperty("activity_type")]
    public string ActivityType { get; set; }

    [JsonProperty("activity_description")]
    public string ActivityDescription { get; set; }
}
