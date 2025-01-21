using DotnetIntercomAPI.Models.BaseModels;
using DotnetIntercomAPI.Models.Contacts;

namespace DotnetIntercomAPI.Responses.Contacts;

public class ContactCreateOrUpdateResponse : BaseResponse
{
    public string Type { get; set; }
    public string Id { get; set; }
    public string ExternalId { get; set; }
    public string WorkspaceId { get; set; }
    public string Role { get; set; }
    public string Email { get; set; }
    public string EmailDomain { get; set; }
    public string Phone { get; set; }
    public string FormattedPhone { get; set; }
    public string Name { get; set; }
    public int? OwnerId { get; set; }
    public bool HasHardBounced { get; set; }
    public bool MarkedEmailAsSpam { get; set; }
    public bool UnsubscribeFromEmails { get; set; }
    public int CreatedAt { get; set; }
    public int UpdatedAt { get; set; }
    public int? SignedUpAt { get; set; }
    public int? LastSeenAt { get; set; }
    public int? LastRepliedAt { get; set; }
    public int? LastContactAt { get; set; }
    public int? LastEmailOpenedAt { get; set; }
    public int? LastEmailClickedAt { get; set; }
    public string LanguageOverride { get; set; }
    public string Browser { get; set; }
    public string BrowserVersion { get; set; }
    public string BrowserLanguage { get; set; }
    public string Os { get; set; }
    public string AndroidAppName { get; set; }
    public string AndroidAppVersion { get; set; }
    public string AndroidDevice { get; set; }
    public string AndroidOsVersion { get; set; }
    public string AndroidSdkVersion { get; set; }
    public int? AndroidLastSeenAt { get; set; }
    public string IosAppName { get; set; }
    public string IosAppVersion { get; set; }
    public string IosDevice { get; set; }
    public string IosOsVersion { get; set; }
    public string IosSdkVersion { get; set; }
    public int? IosLastSeenAt { get; set; }
    public object CustomAttributes { get; set; }
    public IntercomAvatar Avatar { get; set; }
    public ContactTag Tags { get; set; }
    public ContactNote Notes { get; set; }
    public ContactCompany Companies { get; set; }
    public IntercomLocation Location { get; set; }
    public ContactSocialProfile SocialProfiles { get; set; }
    public string UtmCampaign { get; set; }
    public string UtmContent { get; set; }
    public string UtmMedium { get; set; }
    public string UtmSource { get; set; }
    public string UtmTerm { get; set; }
    public string Referrer { get; set; }
}
