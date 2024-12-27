using System.ComponentModel.DataAnnotations;

namespace JWTdotNet.Models
{
    public class RegisterModel
    {
        [StringLength(100)]
        public string Firsname { get; set; }
        
        [StringLength(100)]
        public string Lastname { get; set; }
        
        [StringLength(50)]
        public string Username { get; set; }
        
        [StringLength(128)]
        public string Email { get; set; }

        [StringLength(256)]
        public string Password { get; set; }
    }
}
