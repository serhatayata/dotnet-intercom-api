using DotnetIntercomAPI.Models.DataAttributes;

namespace DotnetIntercomAPI.Responses.DataAttributes;

public class DataAttributeListResponse : BaseResponse
{
    public List<DataAttributeModel> Data { get; set; }
}
