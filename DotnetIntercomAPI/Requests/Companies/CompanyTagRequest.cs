using DotnetIntercomAPI.Models.Companies;

namespace DotnetIntercomAPI.Requests.Companies;

public class CompanyTagRequest
{
    public string Name { get; set; }
    public List<CompaniesTag> Companies { get; set; }
}