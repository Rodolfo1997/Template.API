using System;

namespace Template.Domains
{
    public class Character
    {
        public static Character From(string name, string description)
        {
            return new Character(name, description);
        }

        public string Name { get; private set; }
        public string Description { get; private set; }

        private Character(string name, string description)
        {
            Name = name;
            Description = description;
        }
        
        public override bool Equals(object obj)
        {
            return obj is Character character &&
                   Name == character.Name &&
                   Description == character.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description);
        }
    }
}