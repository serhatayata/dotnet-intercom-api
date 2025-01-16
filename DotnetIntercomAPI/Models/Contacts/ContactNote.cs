namespace DotnetIntercomAPI.Models.Contacts;

public class ContactNote
{
    public List<ContactNoteData> Data { get; set; }
    public string Url { get; set; }
    public string TotalCount { get; set; }
    public string HasMore { get; set; }
}
