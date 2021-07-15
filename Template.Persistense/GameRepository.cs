using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Domains;
using Template.Persistense.API;

namespace Template.Persistense
{
    public class GameRepository : IGameRepository
    {
        private readonly Dictionary<GameKey, IGame> gameStore = new Dictionary<GameKey, IGame>();

        public async Task AddGame(IGame game)
        {
            gameStore.Add(game.Key, game);
        }

        public async Task<IGame> GetGameBy(GameKey gameKey)
        {
            if(!gameStore.TryGetValue(gameKey, out var game))
            {
                return null;
            }

            return game;
        }

        public async Task<IGame[]> GetAllGames()
        {
            return gameStore.Values.ToArray();
        }
    }
}