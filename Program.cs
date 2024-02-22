using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PersonalWebsite;

var builder = WebApplication.CreateSlimBuilder(args);
builder.Services.AddMvc();
builder.WebHost.UseKestrelHttpsConfiguration();
builder.WebHost.UseQuic();

var app = builder.Build();
app.UseExceptionHandler("/Error");
app.UseHsts();
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseStatusCodePagesWithRedirects("/Error/{0}");
app.UseRouting();
app.MapControllerRoute(name: "OnlyAction",
                       pattern: "{action}/{id?}",
                       defaults: new { controller = "Home", action = "Index" });
app.Run();