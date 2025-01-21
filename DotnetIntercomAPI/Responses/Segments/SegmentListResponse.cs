using DotnetIntercomAPI.Models.Segments;

namespace DotnetIntercomAPI.Responses.Segments;

public class SegmentListResponse : BaseResponse
{
    public List<SegmentModel> Data { get; set; }
}
