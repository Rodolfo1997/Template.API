using System.Linq;
using System.Threading.Tasks;
using Template.API.Factories;
using Template.API.ViewItems;
using Template.Core.API;
using Template.Domains;

namespace Template.API.Presenters
{
    public class GamePresenter : IGamePresenter
    {
        private readonly IGameService gameService;

        public GamePresenter(IGameService gameService)
        {
            this.gameService = gameService;
        }

        public async Task<GameDTO> AddGame(GameDTO game)
        {
            var gameFactory = new GameFactory();
            var result = gameFactory.Create(game);
            await gameService.AddGame(gameFactory.Create(game));

            return ConvertTo(result);
        }

        public async Task<GameDTO[]> GetAllGames()
        {
            var result = await gameService.GetAllGames();
            return result.Select(item => ConvertTo(item)).ToArray();
        }

        private GameDTO ConvertTo(IGame game)
        {
            return new GameDTO()
            {
                Name = game.Name,
                Description = game.Description,
                Type = (int)game.Type,
                Key = game.Key.Value.ToString(),
                Characters = game.Characters.Select(item => new CharacterDTO() { Name = item.Name, Description = item.Description }).ToArray()
            };
        }
    }
}
