namespace DotnetIntercomAPI.Models.BaseModels;

/// <summary>
/// The object who initiated the conversation, which can be a Contact, Admin or Team. 
/// Bots and campaigns send messages on behalf of Admins or Teams. For Twitter, this will be blank.
/// </summary>
public class IntercomAuthor
{
    public string Type { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}
