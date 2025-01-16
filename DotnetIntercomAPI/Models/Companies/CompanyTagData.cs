namespace DotnetIntercomAPI.Models.Companies;

public class CompanyTagData
{
    public string Type { get; set; }
    public string Id { get; set; }
    public int AppliedAt { get; set; }
    public CompanyTagApplying AppliedBy { get; set; }
}
