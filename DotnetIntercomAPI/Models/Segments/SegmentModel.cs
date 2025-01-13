using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Segments;

public class SegmentModel
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("created_at")]
    public int CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public int UpdatedAt { get; set; }

    [JsonProperty("person_type")]
    public string PersonType { get; set; }

    [JsonProperty("count")]
    public int Count { get; set; }
}
