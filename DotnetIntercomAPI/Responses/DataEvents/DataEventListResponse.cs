using DotnetIntercomAPI.Models.BaseModels;
using DotnetIntercomAPI.Models.DataEvents;

namespace DotnetIntercomAPI.Responses.DataEvents;

public class DataEventListResponse : BaseResponse
{
    public string Email { get; set; }
    public string IntercomUserId { get; set; }
    public string UserId { get; set; }
    public List<DataEventModel> Events { get; set; }
    public PagesModel Pages { get; set; }
}
