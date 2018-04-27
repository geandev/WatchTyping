using MediatR;
using System.Threading.Tasks;
using WatchTyping.Core.Bus;
using WatchTyping.Core.Events;

namespace WatchTyping.Infra.Bus
{
    public class MediatorBus : IBus
    {
        private readonly IMediator _mediator;

        public MediatorBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<TResponse> RaiseEventAsync<TResponse>(IEvent<TResponse> @event)
        {
            return _mediator.Send<TResponse>(@event);
        }
    }
}
