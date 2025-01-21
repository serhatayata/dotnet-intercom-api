using DotnetIntercomAPI.Models.Contacts;

namespace DotnetIntercomAPI.Requests.Contacts;

public class ContactTagRequest
{
    public string Name { get; set; }
    public List<ContactsTag> Users { get; set; }
}
