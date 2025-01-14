using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Contacts;

public class ContactDeleteResponse : BaseResponse
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("external_id")]
    public string ExternalId { get; set; }

    [JsonProperty("deleted")]
    public bool Deleted { get; set; }
}
