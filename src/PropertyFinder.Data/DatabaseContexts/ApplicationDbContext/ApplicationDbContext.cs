using Microsoft.EntityFrameworkCore;
using PropertyFinder.Data.Entities;

namespace PropertyFinder.Data.DatabaseContexts.AuthenticationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}