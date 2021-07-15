using System.Threading.Tasks;
using Template.Domains;

namespace Template.Core.API
{
    public interface IGameService
    {
        Task AddGame(IGame game);
        Task<IGame[]> GetAllGames();
    }
}
