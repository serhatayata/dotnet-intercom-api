using DotnetIntercomAPI.Models;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Admins;

public class IdentifyAdminResponse : BaseResponse
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("email_verified")]
    public bool EmailVerified { get; set; }

    [JsonProperty("app")]
    public IntercomAppModel App { get; set; }

    [JsonProperty("avatar")]
    public IntercomAvatarModel Avatar { get; set; }

    [JsonProperty("has_inbox_seat")]
    public bool HasInboxSeat { get; set; }
}
