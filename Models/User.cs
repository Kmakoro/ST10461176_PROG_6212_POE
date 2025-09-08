namespace ST10461176_PROG_6212_POE.Models
{
    public class User
    {

        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Phone { get; set; } 
        public string Role { get; set; } = string.Empty; // e.g., "Admin", "User"
    }
}
