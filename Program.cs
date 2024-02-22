using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PersonalWebsite;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

var app = builder.Build();

app.UseExceptionHandler("/Error");
app.UseHsts();
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseStatusCodePagesWithRedirects("/Error/{0}");
app.UseRouting();
app.UseEndpoints(routes => routes.MapControllerRoute(name: "OnlyAction", pattern: "{action}/{id?}", defaults: new { controller = "Home", action = "Index" }));
app.Run();