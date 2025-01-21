namespace DotnetIntercomAPI.Models.BaseModels;

public class PagesModel
{
    public string Type { get; set; }
    public NextPageModel? Next { get; set; }
    public int? Page { get; set; }
    public int? PerPage { get; set; }
    public int? TotalPages { get; set; }
}
