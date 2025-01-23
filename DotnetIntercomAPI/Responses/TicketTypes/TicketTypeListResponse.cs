using DotnetIntercomAPI.Models.TicketTypes;

namespace DotnetIntercomAPI.Responses.TicketTypes;

public class TicketTypeListResponse : BaseResponse
{
    public List<TicketTypeModel> Data { get; set; }
}
