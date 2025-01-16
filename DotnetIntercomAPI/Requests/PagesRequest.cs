using DotnetIntercomAPI.Models;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Requests;

public class PagesRequest
{
    public string? Type { get; set; }
    public NextPageModel? Next { get; set; }
    public int? Page { get; set; }
    public int? PerPage { get; set; }
    public int? TotalPages { get; set; }
    public string? Order { get; set; }
}
