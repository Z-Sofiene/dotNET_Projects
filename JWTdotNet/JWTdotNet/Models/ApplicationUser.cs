using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JWTdotNet.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
    }
}
