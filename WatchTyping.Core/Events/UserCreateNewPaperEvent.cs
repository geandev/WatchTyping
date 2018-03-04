namespace WatchTyping.Core.Events
{
    public class UserCreateNewPaperEvent : IEvent
    {
        public string ConnectionId { get; set; }
        public string GroupId { get; set; }
    }
}
