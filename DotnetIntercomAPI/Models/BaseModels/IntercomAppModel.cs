namespace DotnetIntercomAPI.Models.BaseModels;

public class IntercomAppModel
{
    public string Type { get; set; }
    public string IdCode { get; set; }
    public string Name { get; set; }
    public long CreatedAt { get; set; }
    public bool Secure { get; set; }
    public bool IdentityVerification { get; set; }
    public string TimeZone { get; set; }
    public string Region { get; set; }
}
