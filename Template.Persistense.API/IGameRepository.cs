using System.Threading.Tasks;
using Template.Domains;

namespace Template.Persistense.API
{
    public interface IGameRepository
    {
        Task AddGame(IGame game);
        Task<IGame[]> GetAllGames();
    }
}