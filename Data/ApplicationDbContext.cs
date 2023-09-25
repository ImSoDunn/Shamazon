using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shamazon.Models;

namespace Shamazon.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Shamazon.Models.Item>? Item { get; set; }
        public DbSet<Shamazon.Models.ShoppingCart>? ShoppingCart { get; set; }
    }
}