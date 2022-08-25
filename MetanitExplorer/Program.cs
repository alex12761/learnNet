using MetanitExplorer;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var qwe = "QwE";
var temp = qwe.ToLower();

app.Map("/time", (appBuilder ) => { });
app.UseToken();
app.Use(async (HttpContext context, Func<Task> next) =>
{
    await context.Response.WriteAsync("Hello Work!");
    // next.Invoke();
});

app.Run();