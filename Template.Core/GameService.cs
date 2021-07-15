using System.Threading.Tasks;
using Template.Core.API;
using Template.Domains;
using Template.Persistense.API;

namespace Template.Core
{
    public class GameService : IGameService
    {
        private readonly IGameRepository gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public async Task AddGame(IGame game)
        {
            await gameRepository.AddGame(game);
        }

        public async Task<IGame[]> GetAllGames()
        {
            return await gameRepository.GetAllGames();
        }
    }
}