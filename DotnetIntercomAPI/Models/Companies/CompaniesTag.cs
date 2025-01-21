namespace DotnetIntercomAPI.Models.Companies;

public class CompaniesTag
{
    /// <summary>
    /// The Intercom defined id representing the company.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The company id you have defined for the company.
    /// </summary>
    public string CompanyId { get; set; }

    public bool Untag { get; set; } = false;
}
