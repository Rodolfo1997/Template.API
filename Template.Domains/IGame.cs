namespace Template.Domains
{
    public interface IGame
    {
        GameKey Key { get; }
        string Name { get; }
        string Description { get; }
        GameType Type { get; }
        Character[] Characters { get; }
    }
}
