namespace Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string URLProfileImg { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Username { get; set; }
    }
}
