using DotnetIntercomAPI.Attributes;

namespace DotnetIntercomAPI.Configurations.Installers.BuilderInstallers;

[InstallerOrder(Order = 2)]
public class ApiDocumentationServiceInstaller : IBuilderInstaller
{
    public Task Install(WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApi();
        
        return Task.CompletedTask;
    }
}
