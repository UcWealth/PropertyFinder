using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PropertyFinder.Data.Entities;

namespace PropertyFinder.Data.DatabaseContexts.AuthenticationDbContext
{
    public class AuthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext>options) : base(options)
        {

        }
    }
}