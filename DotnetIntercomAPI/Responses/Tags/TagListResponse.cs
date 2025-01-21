using DotnetIntercomAPI.Models.Tags;

namespace DotnetIntercomAPI.Responses.Tags;

public class TagListResponse : BaseResponse
{
    public List<TagModel> Data { get; set; }
}
