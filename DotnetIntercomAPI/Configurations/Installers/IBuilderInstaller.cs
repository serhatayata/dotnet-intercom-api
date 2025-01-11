namespace DotnetIntercomAPI.Configurations.Installers;

public interface IBuilderInstaller
{
    Task Install(WebApplicationBuilder builder);
}
