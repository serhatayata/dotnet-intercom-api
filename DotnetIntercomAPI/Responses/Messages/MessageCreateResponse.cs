namespace DotnetIntercomAPI.Responses.Messages;

public class MessageCreateResponse
{
    public string Type { get; set; }
    public string Id { get; set; }
    public int CreatedAt { get; set; }
    public string Body { get; set; }
    public string MessageType { get; set; }
    public string ConversationId { get; set; }
}
