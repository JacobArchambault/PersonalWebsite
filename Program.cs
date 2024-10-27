using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateSlimBuilder(args);
builder.Services.AddMvc();
builder.WebHost.UseKestrelHttpsConfiguration();
builder.WebHost.UseQuic();

var app = builder.Build();
app.UseExceptionHandler("/Error");
app.UseHsts();
app.UseHttpsRedirection();

app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = ctx =>
    {
        // Set Cache-Control header to cache images for 7 days (604800 seconds)
        var context = ctx.Context;
        var path = context.Request.Path.Value;
        if (path.Contains("/images/") || path.EndsWith(".css"))
        {
            context.Response.Headers["Cache-Control"] = "public, max-age=604800";
        }
    }
});
app.UseStatusCodePagesWithRedirects("/Error/{0}");
app.UseRouting();
app.MapControllerRoute(name: "OnlyAction",
                       pattern: "{action}/{id?}",
                       defaults: new { controller = "Home", action = "Index" });
app.Run();
