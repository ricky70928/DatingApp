namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; } = String.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}