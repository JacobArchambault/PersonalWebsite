using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateSlimBuilder(args);
builder.Services.AddMvc();
builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
});
builder.WebHost.UseKestrelHttpsConfiguration();
builder.WebHost.UseQuic();



var app = builder.Build();
app.UseResponseCompression();
app.UseExceptionHandler("/Error");
app.UseHsts();
app.UseHttpsRedirection();
var provider = new FileExtensionContentTypeProvider();
// Add new mappings
provider.Mappings[".avif"] = "image/avif";
app.UseStaticFiles(new StaticFileOptions
{
    ContentTypeProvider = provider,
    OnPrepareResponse = ctx =>
    {
        // Set Cache-Control header to cache images for 7 days (604800 seconds)
        var context = ctx.Context;
        var path = context.Request.Path.Value;
        if (path.Contains("/images/") || path.EndsWith(".css"))
        {
            context.Response.Headers["Cache-Control"] = "public, max-age=31536000";
        }
    }
});
app.UseStatusCodePagesWithRedirects("/Error/{0}");
app.UseRouting();
app.MapControllerRoute(name: "OnlyAction",
                       pattern: "{action}/{id?}",
                       defaults: new { controller = "Home", action = "Index" });
app.Run();
