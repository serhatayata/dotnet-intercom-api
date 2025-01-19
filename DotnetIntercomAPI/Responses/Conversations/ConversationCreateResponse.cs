namespace DotnetIntercomAPI.Responses.Conversations;

public class ConversationCreateResponse : BaseResponse
{
    public string Id { get; set; }
    public int CreatedAt { get; set; }
    public string Body { get; set; }
    public string MessageType { get; set; }
    public string ConversationId { get; set; }
}
