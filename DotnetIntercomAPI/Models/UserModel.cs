using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models;

public class UserModel
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("ip")]
    public string Ip { get; set; }
}
