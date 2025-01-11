using DotnetIntercomAPI.Attributes;
using DotnetIntercomAPI.Models;
using DotnetIntercomAPI.Services.Abstract;
using DotnetIntercomAPI.Services.Concrete;

namespace DotnetIntercomAPI.Configurations.Installers.BuilderInstallers;

[InstallerOrder(Order = 4)]
public class StartupDIServiceInstaller : IBuilderInstaller
{
    public Task Install(WebApplicationBuilder builder)
    {
        #region DI
        builder.Services.AddSingleton<IIntercomService, IntercomService>();
        #endregion
        #region Configure
        builder.Services.Configure<IntercomOptions>(builder.Configuration.GetSection("IntercomOptions"));
        #endregion

        return Task.CompletedTask;
    }
}
