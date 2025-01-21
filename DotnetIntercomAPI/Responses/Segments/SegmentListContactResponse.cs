using DotnetIntercomAPI.Models.Segments;

namespace DotnetIntercomAPI.Responses.Segments;

public class SegmentListContactResponse : BaseResponse
{
    public List<SegmentModel> Data { get; set; }
}
