namespace DotnetIntercomAPI.Requests.Segments;

public class SegmentListRequest
{
    /// <summary>
    /// It includes the count of contacts that belong to each segment.
    /// </summary>
    public bool IncludeCount { get; set; }
}
