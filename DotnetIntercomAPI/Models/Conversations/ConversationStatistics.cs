namespace DotnetIntercomAPI.Models.Conversations;

public class ConversationStatistics
{
    public string Type { get; set; }
    public int TimeToAssignment { get; set; }
    public int TimeToAdminReply { get; set; }
    public int TimeToFirstClose { get; set; }
    public int TimeToLastClose { get; set; }
    public int MedianTimeToReply { get; set; }
    public int FirstContactReplyAt { get; set; }
    public int FirstAssignmentAt { get; set; }
    public int FirstAdminReplyAt { get; set; }
    public int FirstCloseAt { get; set; }
    public int LastAssignmentAt { get; set; }
    public int LastAssignmentAdminReplyAt { get; set; }
    public int LastContactReplyAt { get; set; }
    public int LastAdminReplyAt { get; set; }
    public int LastCloseAt { get; set; }
    public string LastClosedById { get; set; }
    public int CountReopens { get; set; }
    public int CountAssignments { get; set; }
    public int CountConversationParts { get; set; }
}
