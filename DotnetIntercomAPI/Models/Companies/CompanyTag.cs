using DotnetIntercomAPI.Models.Tags;

namespace DotnetIntercomAPI.Models.Companies;

public class CompanyTag
{
    public string Type { get; set; }
    public List<TagModel> Tags { get; set; }
}
