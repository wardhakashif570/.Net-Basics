var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/*app.MapGet("/", () => "Hello World!");*/

/*app.Run(async (context) =>
{
    context.Response.WriteAsync("Hello");
});*/


///  to run multiple middleware we have to use app.Use instead of app.Run
app.Use(async (context,next) =>
{
    await context.Response.WriteAsync("Hello \n");
    await next(context);
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello 1");
});
 
app.Run();
