using DotnetIntercomAPI.Models.Contacts;

namespace DotnetIntercomAPI.Models.Conversations;

public class ConversationContacts
{
    public string Type { get; set; }
    public List<ContactReference> Contacts { get; set; }
}
