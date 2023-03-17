using System;
using System.Net;
using Microsoft.AspNetCore.Hosting;

namespace Centrifuge.Server;

class Program
{
    static void Main(string[] args)
    {
        var host = new WebHostBuilder()
        .UseKestrel(options => {
            // Disable HTTPS endpoint
            options.Listen(IPAddress.Loopback, 8500);
        }).UseStartup<Startup>().Build();

        host.Run();
    }
}