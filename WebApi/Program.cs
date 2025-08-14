using WebApi.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.ConfigureDefaultAdminUser();

app.Run();
