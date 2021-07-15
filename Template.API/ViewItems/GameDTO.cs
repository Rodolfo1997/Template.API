namespace Template.API.ViewItems
{
    public class GameDTO
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public CharacterDTO[] Characters { get; set; }
    }
}
