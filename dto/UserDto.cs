using System.ComponentModel.DataAnnotations;

namespace Player_mgt_system.dto
{
    public class UserDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
