using DotnetIntercomAPI.Models.Contacts;

namespace DotnetIntercomAPI.Models.Companies;

public class CompanyModel
{
    public string Type { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string AppId { get; set; }
    public CompanyPlan Plan { get; set; }
    public string CompanyId { get; set; }
    public int RemoteCreatedAt { get; set; }
    public int CreatedAt { get; set; }
    public int UpdatedAt { get; set; }
    public int LastRequestAt { get; set; }
    public int Size { get; set; }
    public string Website { get; set; }
    public string Industry { get; set; }
    public int MonthlySpend { get; set; }
    public int SessionCount { get; set; }
    public int UserCount { get; set; }
    public object CustomAttributes { get; set; }
    public CompanyTag Tags { get; set; }
    public ContactSegment Segments { get; set; }
}
