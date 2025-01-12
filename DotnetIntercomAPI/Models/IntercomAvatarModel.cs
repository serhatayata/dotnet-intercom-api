using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models;

public class IntercomAvatarModel
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("image_url")]
    public string ImageUrl { get; set; }
}
