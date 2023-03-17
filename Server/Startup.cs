using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Centrifuge.Server;
public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        services.AddRouting();
    }

    public void Configure(IApplicationBuilder app) {
    app.UseRouting();
    app.UseEndpoints(endpoints => {
        endpoints.MapGet("/", context => {
            return context.Response.WriteAsync("Hello, world!");
        });
    });
    }
}