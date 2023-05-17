using System.ComponentModel.DataAnnotations;

namespace Catistgram.Server.Models.Identity
{
    public class LoginuserRequestModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
