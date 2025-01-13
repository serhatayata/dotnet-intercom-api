using DotnetIntercomAPI.Models.Segments;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Contacts;

public class ContactSegment
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("data")]
    public List<SegmentModel> Data { get; set; }
}
