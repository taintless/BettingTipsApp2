namespace webapi.Db.Entities
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Team1Name { get; set; }
        public string Team2Name { get; set; }
        public string League { get; set; }
        public int TeamToBet { get; set; }
        public DateTime GameTime { get; set; }
    }
}
