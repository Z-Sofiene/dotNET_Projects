using Microsoft.EntityFrameworkCore;
using JWTdotNet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace JWTdotNet.Config
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
