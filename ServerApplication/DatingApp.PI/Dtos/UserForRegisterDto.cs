using System.ComponentModel.DataAnnotations;

namespace DatingApp.PI.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4,ErrorMessage = "Password length should be between 4 and 8")]
        public string Password { get; set; }
    }
}