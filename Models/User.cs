
namespace backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int AvatarId { get; set; }
        public int Level { get; set; }
        public List<Record> Records { get; set; } = new();
    }

}