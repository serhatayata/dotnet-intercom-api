using System.Net.Http.Headers;
using DotnetIntercomAPI.Attributes;
using DotnetIntercomAPI.Models;

namespace DotnetIntercomAPI.Configurations.Installers.BuilderInstallers;

[InstallerOrder(Order = 5)]
public class HttpClientServiceInstaller : IBuilderInstaller
{
    public Task Install(WebApplicationBuilder builder)
    {
        builder.Services.AddHttpClient("intercom", c =>
        {
            var intercomOptions = builder.Configuration.GetSection("IntercomOptions").Get<IntercomOptions>();

            c.BaseAddress = new Uri(intercomOptions.BaseUrl);
            c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", intercomOptions.AccessToken);
            c.DefaultRequestHeaders.Add("Intercom-Version", intercomOptions.Version);
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        });

        return Task.CompletedTask;
    }
}
