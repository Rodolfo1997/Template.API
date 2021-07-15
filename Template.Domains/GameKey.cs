using System;

namespace Template.Domains
{
    public class GameKey
    {
        public static GameKey New()
        {
            return new GameKey(Guid.NewGuid());
        }

        public static GameKey From(string value)
        {
            if (!Guid.TryParse(value, out var result))
            {
                throw new ArgumentException("Invalid GUID");
            }

            return new GameKey(result);
        }

        public Guid Value { get; private set; }

        private GameKey(Guid value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is GameKey key &&
                   Value.Equals(key.Value);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }

    }
}