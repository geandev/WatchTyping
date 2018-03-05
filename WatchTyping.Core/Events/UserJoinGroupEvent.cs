namespace WatchTyping.Core.Events
{
    public class UserJoinGroupEvent : IEvent
    {
        public string ConnectionId { get; set; }
        public string GroupId { get; set; }
    }
}
