namespace GlobalOutsourcingServices.Services.Domain.Entities
{
    public class UserModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
