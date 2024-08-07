namespace ContactosApi.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? UserId { get; set; }
    }

    public class User
    {
        public string? Id { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
    }
}