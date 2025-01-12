using DotnetIntercomAPI.Models;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Admins;

public class ListAllActivityLogsResponse : BaseResponse
{
    [JsonProperty("pages")]
    public PagesModel Pages { get; set; }

    [JsonProperty("activity_logs")]
    public List<ActivityLogModel> ActivityLogs { get; set; }
}
