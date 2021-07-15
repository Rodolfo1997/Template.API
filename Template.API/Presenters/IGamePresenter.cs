using System.Threading.Tasks;
using Template.API.ViewItems;

namespace Template.API.Presenters
{
    public interface IGamePresenter
    {
        Task<GameDTO> AddGame(GameDTO game);
        Task<GameDTO[]> GetAllGames();
    }
}
