using DotnetIntercomAPI.Attributes;

namespace DotnetIntercomAPI.Configurations.Installers.BuilderInstallers;

[InstallerOrder(Order = 1)]
public class ControllerServiceInstaller : IBuilderInstaller
{
    public Task Install(WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();

        return Task.CompletedTask;
    }
}
