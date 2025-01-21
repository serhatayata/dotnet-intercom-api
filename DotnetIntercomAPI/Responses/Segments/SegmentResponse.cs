namespace DotnetIntercomAPI.Responses.Segments;

public class SegmentResponse : BaseResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int CreatedAt { get; set; }
    public int UpdatedAt { get; set; }
    public string PersonType { get; set; }
}
