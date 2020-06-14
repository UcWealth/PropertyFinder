using Microsoft.EntityFrameworkCore;

namespace PropertyFinder.Data.DatabaseContexts.AuthenticationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}