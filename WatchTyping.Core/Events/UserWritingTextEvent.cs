using System;

namespace WatchTyping.Core.Events
{
    public class UserWritingTextEvent : IEvent<UserWritingTextEvent>
    {
        public string ConnectionId { get; set; }
        public string GroupId { get; set; }
        public string Message { get; set; }
    }
}
