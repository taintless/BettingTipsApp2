namespace webapi.Models
{
    public class SendEmailResource
    {
        public required List<Guid> Users { get; set; }
        public required List<Guid> Games { get; set; }
    }
}
