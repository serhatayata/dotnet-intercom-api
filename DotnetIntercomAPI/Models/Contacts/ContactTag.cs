namespace DotnetIntercomAPI.Models.Contacts;

public class ContactTag
{
    public List<ContactTagData> Data { get; set; }
    public string Url { get; set; }
    public string TotalCount { get; set; }
    public string HasMore { get; set; }
}
