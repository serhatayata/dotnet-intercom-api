using Newtonsoft.Json;

namespace DotnetIntercomAPI.Requests.Contacts;

public class ContactCreateOrUpdateRequest
{
    [JsonProperty("role")]
    public string Role { get; set; }

    [JsonProperty("external_id")]
    public string ExternalId { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("phone")]
    public string Phone { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("avatar")]
    public string Avatar { get; set; }

    [JsonProperty("signed_up_at")]
    public int SignedUpAt { get; set; }

    [JsonProperty("last_seen_at")]
    public int LastSeenAt { get; set; }

    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    [JsonProperty("unsubscribed_from_emails")]
    public bool UnsubscribedFromEmails { get; set; }

    [JsonProperty("custom_attributes")]
    public object CustomAttributes { get; set; }
}
