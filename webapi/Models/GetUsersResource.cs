namespace webapi.Models
{
    public class GetUsersResource
    {
        public Guid Id { get; set; }
        public required string Email { get; set; }
        public List<Guid> UserGames { get; set; }
    }
}
