using System.ComponentModel.DataAnnotations;

namespace Models.Domain.Users
{
    public class UserLogin
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8)]
        public string Password { get; set; }
    }
}