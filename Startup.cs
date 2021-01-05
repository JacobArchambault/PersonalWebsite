using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace PersonalWebsite
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) => services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseStatusCodePagesWithRedirects("/Error/{0}");
            app.UseRouting();
            app.UseEndpoints(routes => routes.MapControllerRoute(name: "OnlyAction", pattern: "{action}/{id?}", defaults: new { controller = "Home", action = "Index" }));
        }
    }
}