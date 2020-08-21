using System.Threading.Tasks;

namespace AwesomeLeaderBoard.Services
{
public interface ILeaderBoardService
{
Task<ILeaderBoardService[]> GetIncompleteItemsAsync();
}
}
