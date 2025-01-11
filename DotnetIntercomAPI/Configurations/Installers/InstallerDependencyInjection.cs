using System.Reflection;
using DotnetIntercomAPI.Attributes;

namespace DotnetIntercomAPI.Configurations.Installers;

public static class InstallerDependencyInjection
{
    public async static Task<WebApplicationBuilder> InstallBuilder(
    this WebApplicationBuilder builder)
    {
        var assemblies = new List<Assembly>() { typeof(IBuilderInstaller).Assembly };

        IEnumerable<IBuilderInstaller> installers = assemblies
            .SelectMany(a => a.DefinedTypes)
            .Where(IsAssignableToType<IBuilderInstaller>)
            .Select(Activator.CreateInstance)
            .Cast<IBuilderInstaller>()
            .OrderBy(ord =>
            {
                var att = ord.GetType()
                             .GetCustomAttributes(typeof(InstallerOrderAttribute), true)
                             .FirstOrDefault() as InstallerOrderAttribute;

                if (att == null)
                    return int.MaxValue;

                return att.Order;
            });

        foreach (IBuilderInstaller installer in installers)
        {
            await installer.Install(builder);
        }

        return builder;

        static bool IsAssignableToType<T>(TypeInfo typeInfo) =>
            typeof(T).IsAssignableFrom(typeInfo) &&
            !typeInfo.IsInterface &&
            !typeInfo.IsAbstract;
    }
}
