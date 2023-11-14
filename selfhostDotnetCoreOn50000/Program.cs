using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

class Program
{
    static void Main()
    {
        CreateWebHostBuilder().Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder() =>
        WebHost.CreateDefaultBuilder()
        .UseUrls("http://localhost:50000")
            .Configure(app =>
            {
                app.Run(context =>
                {
                    return context.Response.WriteAsync("Hello, ASP.NET Core Self-Hosted World!");
                });
            });
}
