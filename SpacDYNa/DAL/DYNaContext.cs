using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpacDYNa.Models;

namespace SpacDYNa.DAL
{
    public class DYNaContext : IdentityDbContext
    {
        public DYNaContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
