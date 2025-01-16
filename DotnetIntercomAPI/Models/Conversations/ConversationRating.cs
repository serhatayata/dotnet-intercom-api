using DotnetIntercomAPI.Models.Contacts;

namespace DotnetIntercomAPI.Models.Conversations;

public class ConversationRating
{
    public int Rating { get; set; }
    public string Remark { get; set; }
    public int CreatedAt { get; set; }
    public ContactReference Contact { get; set; }
}
