namespace webapi.Db.Entities
{
    public class RegisteredUser
    {
        public Guid Id { get; set; }
        public required string Email { get; set; }
    }
}
