using System.Threading.Tasks;
using WatchTyping.Core.Models;

namespace WatchTyping.Infra.Hubs
{
    public interface IWritingTypingHubClientFacade
    {
        void UserJoinGroupEvent(string lastMessage);
        void UserCreateNewPaperEvent(string groupId);
        void UserWritingTextEvent(string message);
    }
}