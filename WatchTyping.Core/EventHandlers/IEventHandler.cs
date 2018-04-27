using MediatR;

namespace WatchTyping.Core.EventHandlers
{
    public interface IEventHandler<TEvent, TReponse> : IRequestHandler<TEvent, TReponse>
        where TEvent : IRequest<TReponse>
    {
    }
}
