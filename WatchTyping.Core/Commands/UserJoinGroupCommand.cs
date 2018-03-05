namespace WatchTyping.Core.Commands
{
    public class UserJoinGroupCommand : ICommand
    {
        public string ConnectionId { get; set; }
        public string GroupId { get; set; }
    }
}
