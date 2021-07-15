using System.Collections.Generic;
using System.Linq;

namespace Template.Domains
{
    public class ShootingGames : IGame
    {
        private readonly HashSet<Character> characters = new HashSet<Character>();

        public GameKey Key { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public GameType Type { get { return GameType.Shooting; } }
        public Character[] Characters { get { return characters.ToArray(); } }

        public ShootingGames(GameKey key, string name, string description, Character[] characters)
        {
            Key = key;
            Name = name;
            Description = description;
            AddCharacters(characters);
        }

        public void AddCharacters(Character[] characters)
        {
            foreach (var character in characters)
            {
                AddCharacter(character);
            }
        }

        public void AddCharacter(Character character)
        {
            characters.Add(character);
        }
    }
}