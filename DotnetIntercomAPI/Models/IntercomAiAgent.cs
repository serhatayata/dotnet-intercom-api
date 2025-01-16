namespace DotnetIntercomAPI.Models;

public class IntercomAiAgent
{
    public string SourceType { get; set; }
    public string SourceTitle { get; set; }
    public string LastAnswerType { get; set; }
    public string ResolutionState { get; set; }
    public int? Rating { get; set; }
    public string RatingRemark { get; set; }
    public ContentSourceList ContentSources { get; set; }
}
