using Microsoft.Extensions.DependencyInjection;
using WatchTyping.Infra.CrossCutting;

namespace WatchTyping.Infra
{
    public static class WatchTypingExtension
    {
        public static void UseWatchTyping(this IServiceCollection serviceCollection)
        {
            DependecyInject.Resolve(serviceCollection);
        }
    }
}
