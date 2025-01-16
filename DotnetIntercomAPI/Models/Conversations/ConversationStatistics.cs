namespace DotnetIntercomAPI.Models.Conversations;

public class ConversationStatistics
{
    public string Type { get; set; }
    public int TimeToAssignment { get; set; }
    public int TimeToAdminReply { get; set; }
    public int TimeToFirstClose { get; set; }
    public int TimeToLastClose { get; set; }
    public int MedianTimeToReply { get; set; }
    public DateTime FirstContactReplyAt { get; set; }
    public DateTime FirstAssignmentAt { get; set; }
    public DateTime FirstAdminReplyAt { get; set; }
    public DateTime FirstCloseAt { get; set; }
    public DateTime LastAssignmentAt { get; set; }
    public DateTime LastAssignmentAdminReplyAt { get; set; }
    public DateTime LastContactReplyAt { get; set; }
    public DateTime LastAdminReplyAt { get; set; }
    public DateTime LastCloseAt { get; set; }
    public string LastClosedById { get; set; }
    public int CountReopens { get; set; }
    public int CountAssignments { get; set; }
    public int CountConversationParts { get; set; }
}
