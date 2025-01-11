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
            var intercomOptions = builder.Configuration.GetValue<IntercomOptions>("IntercomOptions");

            c.BaseAddress = new Uri(intercomOptions.BaseUrl);
            c.DefaultRequestHeaders.Add("Authorization", intercomOptions.AccessToken);
            c.DefaultRequestHeaders.Add("Intercom-Version", intercomOptions.Version);
        });

        return Task.CompletedTask;
    }
}
