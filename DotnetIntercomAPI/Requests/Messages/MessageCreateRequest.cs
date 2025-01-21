using DotnetIntercomAPI.Models.BaseModels;

namespace DotnetIntercomAPI.Requests.Messages;

public class MessageCreateRequest
{
    public string MessageType { get; set; }
    public string? Subject { get; set; }
    public string Body { get; set; }
    public string? Template { get; set; }
    public IntercomFrom From { get; set; }
    public IntercomTo To { get; set; }
    public int CreatedAt { get; set; }

    /// <summary>
    /// Whether a conversation should be opened in the inbox for the message without the contact replying. 
    /// Defaults to false if not provided.
    /// </summary>
    public bool CreateConversationWithoutContactReply { get; set; }
}
