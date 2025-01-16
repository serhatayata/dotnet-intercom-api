using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Contacts;

public class ContactDeleteResponse : BaseResponse
{
    public string Id { get; set; }
    public string ExternalId { get; set; }
    public bool Deleted { get; set; }
}
