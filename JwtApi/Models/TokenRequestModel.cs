using System.ComponentModel.DataAnnotations;

namespace JwtApi.Models
{
    public class TokenRequestModel
    {
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        public string Password { get; set; }
    }
}
