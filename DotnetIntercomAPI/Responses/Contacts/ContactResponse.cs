using DotnetIntercomAPI.Models;
using DotnetIntercomAPI.Models.Contacts;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Contacts;

public class ContactResponse
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("external_id")]
    public string ExternalId { get; set; }

    [JsonProperty("workspace_id")]
    public string WorkspaceId { get; set; }

    [JsonProperty("role")]
    public string Role { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("email_domain")]
    public string EmailDomain { get; set; }

    [JsonProperty("phone")]
    public string Phone { get; set; }

    [JsonProperty("formatted_phone")]
    public string FormattedPhone { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("owner_id")]
    public int? OwnerId { get; set; }

    [JsonProperty("has_hard_bounced")]
    public bool HasHardBounced { get; set; }

    [JsonProperty("marked_email_as_spam")]
    public bool MarkedEmailAsSpam { get; set; }

    [JsonProperty("unsubscribed_from_emails")]
    public bool UnsubscribeFromEmails { get; set; }

    [JsonProperty("created_at")]
    public int CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public int UpdatedAt { get; set; }

    [JsonProperty("signed_up_at")]
    public int? SignedUpAt { get; set; }

    [JsonProperty("last_seen_at")]
    public int? LastSeenAt { get; set; }

    [JsonProperty("last_replied_at")]
    public int? LastRepliedAt { get; set; }

    [JsonProperty("last_contacted_at")]
    public int? LastContactAt { get; set; }

    [JsonProperty("last_email_opened_at")]
    public int? LastEmailOpenedAt { get; set; }

    [JsonProperty("last_email_clicked_at")]
    public int? LastEmailClickedAt { get; set; }

    [JsonProperty("language_override")]
    public string LanguageOverride { get; set; }

    [JsonProperty("browser")]
    public string Browser { get; set; }

    [JsonProperty("browser_version")]
    public string BrowserVersion { get; set; }

    [JsonProperty("browser_language")]
    public string BrowserLanguage { get; set; }

    [JsonProperty("os")]
    public string Os { get; set; }

    [JsonProperty("android_app_name")]
    public string AndroidAppName { get; set; }

    [JsonProperty("android_app_version")]
    public string AndroidAppVersion { get; set; }

    [JsonProperty("android_device")]
    public string AndroidDevice { get; set; }

    [JsonProperty("android_os_version")]
    public string AndroidOsVersion { get; set; }

    [JsonProperty("android_sdk_version")]
    public string AndroidSdkVersion { get; set; }

    [JsonProperty("android_last_seen_at")]
    public int? AndroidLastSeenAt { get; set; }

    [JsonProperty("ios_app_name")]
    public string IosAppName { get; set; }

    [JsonProperty("ios_app_version")]
    public string IosAppVersion { get; set; }

    [JsonProperty("ios_device")]
    public string IosDevice { get; set; }

    [JsonProperty("ios_os_version")]
    public string IosOsVersion { get; set; }

    [JsonProperty("ios_sdk_version")]
    public string IosSdkVersion { get; set; }

    [JsonProperty("ios_last_seen_at")]
    public int? IosLastSeenAt { get; set; }

    [JsonProperty("custom_attributes")]
    public object CustomAttributes { get; set; }

    [JsonProperty("avatar")]
    public IntercomAvatarModel Avatar { get; set; }

    [JsonProperty("tags")]
    public ContactTag Tags { get; set; }

    [JsonProperty("notes")]
    public ContactNote Notes { get; set; }

    [JsonProperty("companies")]
    public ContactCompany Companies { get; set; }

    [JsonProperty("location")]
    public IntercomLocationModel Location { get; set; }

    [JsonProperty("social_profiles")]
    public ContactSocialProfile SocialProfiles { get; set; }
}
