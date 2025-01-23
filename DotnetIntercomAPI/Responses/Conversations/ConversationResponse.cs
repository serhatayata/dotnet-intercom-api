using DotnetIntercomAPI.Models.BaseModels;
using DotnetIntercomAPI.Models.Contacts;
using DotnetIntercomAPI.Models.Conversations;
using DotnetIntercomAPI.Models.Tags;

namespace DotnetIntercomAPI.Responses.Conversations;

public class ConversationResponse : BaseResponse
{
    public string Id { get; set; }
    public string Title { get; set; }
    public int CreatedAt { get; set; }
    public int UpdatedAt { get; set; }
    public int? WaitingSince { get; set; }
    public int? SnoozedUntil { get; set; }
    public bool Open { get; set; }
    public string State { get; set; }
    public bool Read { get; set; }
    public string Priority { get; set; }
    public int? AdminAssigneeId { get; set; }
    public int? TeamAssigneeId { get; set; }
    public TagModel Tags { get; set; }
    public ConversationRating? ConversationRating { get; set; }
    public ConversationSource? Source { get; set; }
    public ContactReferenceList? Contacts { get; set; }
    public ConversationTeammate? Teammates { get; set; }
    public object CustomAttributes { get; set; }
    public ConversationFirstContactReply? FirstContactReply { get; set; }
    public SlaApplied? SlaApplied { get; set; }
    public ConversationStatistics? Statistics { get; set; }
    public ConversationPart? ConversationParts { get; set; }
    public LinkedObjectList? LinkedObjects { get; set; }
    public bool AiAgentParticipated { get; set; }
    public IntercomAiAgent? AiAgent { get; set; }
}
