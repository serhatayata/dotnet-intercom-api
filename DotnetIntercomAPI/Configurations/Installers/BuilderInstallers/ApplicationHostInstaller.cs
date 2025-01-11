using DotnetIntercomAPI.Attributes;

namespace DotnetIntercomAPI.Configurations.Installers.BuilderInstallers;

[InstallerOrder(Order = 3)]
public class ApplicationHostInstaller : IBuilderInstaller
{
    public Task Install(
    WebApplicationBuilder builder)
    {
        string env = builder.Environment.EnvironmentName;
        builder.Configuration.AddJsonFile("Configurations/Settings/appsettings.json",
                               optional: false,
                               reloadOnChange: true)
                             .AddJsonFile($"Configurations/Settings/appsettings.{env}.json",
                                          optional: true,
                                          reloadOnChange: true)
                             .AddEnvironmentVariables()
                             .Build();

        return Task.CompletedTask;
    }
}
