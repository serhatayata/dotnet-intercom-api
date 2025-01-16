using DotnetIntercomAPI.Models.Segments;

namespace DotnetIntercomAPI.Models.Contacts;

public class ContactSegment
{
    public string Type { get; set; }
    public List<SegmentModel> Data { get; set; }
}
