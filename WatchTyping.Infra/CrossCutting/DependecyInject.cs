using Microsoft.Extensions.DependencyInjection;
using WatchTyping.Core.Bus;
using WatchTyping.Core.CommandHandlers;
using WatchTyping.Infra.Bus;
using MediatR;
using WatchTyping.Core.Services;
using WatchTyping.Infra.Services;

namespace WatchTyping.Infra.CrossCutting
{
    public class DependecyInject
    {
        private DependecyInject(IServiceCollection services)
        {
            services.AddSingleton<IBus, MediatorBus>();
            services.AddSingleton<IHubService, HubService>();

            services.AddScoped<IUserWritingTextCommandHandler, UserWritingTextCommandHandler>();

            services.AddSignalR();
            services.AddMediatR();

        }

        public static void Resolve(IServiceCollection serviceCollection) => new DependecyInject(serviceCollection);

    }
}
