using WatchTyping.Core.Models;

namespace WatchTyping.Core.Events
{
    public class UserJoinGroupEvent : IEvent
    {
        public string ConnectionId { get; set; }
        public string GroupId { get; set; }
        public Message LastMessage { get; set; }
    }
}
