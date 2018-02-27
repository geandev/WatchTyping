using System.Threading.Tasks;

namespace WatchTyping.Core.Services
{
    public interface IHubService
    {
        Task SendAsync(string message);
    }
}
