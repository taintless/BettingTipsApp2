namespace webapi.Db.Entities
{
    public class UserGame
    {
        public Guid Id { get; set; }
        public Guid RegisteredUserId { get; set; }
        public Guid GameId { get; set; }
        public bool Succeed { get; set; }
        public DateTime Timestamp { get; set; }
        public string? FailureMessage { get; set; }

        public RegisteredUser RegisteredUser { get; set; }
        public Game Game { get; set; }
    }
}
