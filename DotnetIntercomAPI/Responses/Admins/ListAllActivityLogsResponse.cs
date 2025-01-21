using DotnetIntercomAPI.Models.BaseModels;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Admins;

public class ListAllActivityLogsResponse : BaseResponse
{
    public PagesModel Pages { get; set; }
    public List<ActivityLogModel> ActivityLogs { get; set; }
}
