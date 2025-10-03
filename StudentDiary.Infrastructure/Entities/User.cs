namespace StudentDiary.Infrastructure.Entities
{
    public class User
    {
        public int Id { get; set; }           // Primary Key
        public string Username { get; set; }  // Login name
        public string Email { get; set; }     // Contact email
        public string PasswordHash { get; set; } // Hashed password
    }
}
