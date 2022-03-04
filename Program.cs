var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string html = File.ReadAllText("index.htm");

//app.MapGet("/", () => html);

app.MapGet("/", async context =>
{
    await context.Response.WriteAsync(html);
});

app.Run();
