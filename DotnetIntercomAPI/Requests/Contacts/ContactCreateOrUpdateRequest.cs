namespace DotnetIntercomAPI.Requests.Contacts;

public class ContactCreateOrUpdateRequest
{
    public string Role { get; set; }
    public string ExternalId { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Name { get; set; }
    public string Avatar { get; set; }
    public int SignedUpAt { get; set; }
    public int LastSeenAt { get; set; }
    public int OwnerId { get; set; }
    public bool UnsubscribedFromEmails { get; set; }
    public object CustomAttributes { get; set; }
}
