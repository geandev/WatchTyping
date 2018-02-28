using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WatchTyping.Infra.CrossCutting;
using WatchTyping.Infra.Hubs;

namespace WatchTyping.Infra
{
    public static class WatchTypingExtension
    {
        public static void AddWatchTyping(this IServiceCollection services)
        {
            DependecyInject.Resolve(services);
        }

        public static void UseWatchTyping(this IApplicationBuilder app, string route)
        {
            app.UseSignalR(routes => routes.MapHub<WritingTypingHub>(route));
        }
    }
}
