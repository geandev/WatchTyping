namespace WatchTyping.Core.Commands
{
    public class UserWritingTextCommand : ICommand
    {
        public string GroupId { get; set; }
        public string Message { get; set; }
    }
}
