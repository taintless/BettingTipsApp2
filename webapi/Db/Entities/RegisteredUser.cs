namespace webapi.Db.Entities
{
    public class RegisteredUser
    {
        public Guid Id { get; set; }
        public required string Email { get; set; }
        public required DateTime RegsisteredOn { get; set; }

        public List<UserGame> UserGames { get; set; }
    }
}
