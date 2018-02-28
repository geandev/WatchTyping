using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WatchTyping.Infra.CrossCutting;
using WatchTyping.Infra.Services;

namespace WatchTyping.Infra
{
    public static class WatchTypingExtension
    {
        public static void UseWatchTyping(this IServiceCollection services)
        {
            DependecyInject.Resolve(services);
        }

        public static void ConfigureWatchTypingRoute(this IApplicationBuilder app, string route)
        {
            app.UseSignalR(routes => routes.MapHub<SignalRHubService>(route));
        }
    }
}
