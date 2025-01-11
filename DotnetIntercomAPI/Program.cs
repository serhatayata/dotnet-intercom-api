using DotnetIntercomAPI.Configurations.Installers;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

await builder.InstallBuilder();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
