using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Template.API.Presenters;
using Template.API.ViewItems;

namespace Template.API.Controllers
{
    [ApiController]
    [Route("/api/game")]
    public class GameController : ControllerBase
    {
        private readonly IGamePresenter gamePresenter;

        public GameController(IGamePresenter gamePresenter)
        {
            this.gamePresenter = gamePresenter;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllGames()
        {
            return Ok(await gamePresenter.GetAllGames());
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddGame([FromBody] GameDTO game)
        {
            var result = await gamePresenter.AddGame(game);
            return Ok(result);
        }
    }
}
