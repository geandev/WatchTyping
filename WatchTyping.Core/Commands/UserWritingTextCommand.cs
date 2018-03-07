namespace WatchTyping.Core.Commands
{
    public class UserWritingTextCommand : ICommand
    {
        public string ConnectionId { get; set; }
        public string GroupId { get; set; }
        public string Message { get; set; }
    }
}
