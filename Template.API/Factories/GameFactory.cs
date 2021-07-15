using System;
using System.Collections.Generic;
using System.Linq;
using Template.API.ViewItems;
using Template.Domains;

namespace Template.API.Factories
{
    public class GameFactory
    {
        private static readonly Dictionary<GameType, Func<GameDTO, IGame>> map;

        static GameFactory()
        {
            map = new Dictionary<GameType, Func<GameDTO, IGame>>()
            {
                { GameType.Shooting, (dto) => CreateShootingGame(dto)}
            };
        }

        private static IGame CreateShootingGame(GameDTO dto)
        {
            return new ShootingGames(
                GameKey.New(),
                dto.Name,
                dto.Description,
                dto.Characters.Select(item => Character.From(item.Name, item.Description)).ToArray());
        }

        public IGame Create(GameDTO gameDTO)
        {
            if (!map.TryGetValue((GameType)gameDTO.Type, out var result))
            {
                throw new ArgumentException($"Is not possible convert type {gameDTO.Type}");
            }

            return result(gameDTO);
        }
    }
}