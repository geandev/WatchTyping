using MediatR;

namespace WatchTyping.Core.Events
{
    public interface IEvent<TResponse> : IRequest<TResponse>
    {
    }
}
