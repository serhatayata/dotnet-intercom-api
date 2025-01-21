using DotnetIntercomAPI.Models.BaseModels;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses;

public class BaseResponse
{
    public string Type { get; set; }
    public string RequestId { get; set; }
    public List<ErrorModel> Errors { get; set; }
}
