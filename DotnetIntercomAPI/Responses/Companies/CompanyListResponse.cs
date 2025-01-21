using DotnetIntercomAPI.Models.BaseModels;
using DotnetIntercomAPI.Models.Companies;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Companies;

public class CompanyListResponse : BaseResponse
{
    public List<CompanyModel> Data { get; set; }
    public PagesModel Pages { get; set; }
    public int TotalCount { get; set; }
}
