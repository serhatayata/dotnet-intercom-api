using System.Numerics;
using System.Reflection.Metadata;
using DotnetIntercomAPI.Models.Contacts;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Models.Companies;

public class CompanyModel
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("app_id")]
    public string AppId { get; set; }

    [JsonProperty("plan")]
    public CompanyPlan Plan { get; set; }

    [JsonProperty("company_id")]
    public string CompanyId { get; set; }

    [JsonProperty("remote_created_at")]
    public int RemoteCreatedAt { get; set; }

    [JsonProperty("created_at")]
    public int CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public int UpdatedAt { get; set; }

    [JsonProperty("last_request_at")]
    public int LastRequestAt { get; set; }

    [JsonProperty("size")]
    public int Size { get; set; }

    [JsonProperty("website")]
    public string Website { get; set; }

    [JsonProperty("industry")]
    public string Industry { get; set; }

    [JsonProperty("monthly_spend")]
    public int MonthlySpend { get; set; }

    [JsonProperty("session_count")]
    public int SessionCount { get; set; }

    [JsonProperty("user_count")]
    public int UserCount { get; set; }

    [JsonProperty("custom_attributes")]
    public object CustomAttributes { get; set; }

    [JsonProperty("tags")]
    public CompanyTag Tags { get; set; }

    [JsonProperty("segments")]
    public ContactSegment Segments { get; set; }
}
