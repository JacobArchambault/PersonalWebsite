using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using PersonalWebsite;

WebHost.CreateDefaultBuilder(args)
    .UseStartup<Startup>().Build().Run();
