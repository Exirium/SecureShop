using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SecureShop.Models;

namespace SecureShop.Data
{
    public class SecureShopDbContext : IdentityDbContext, ISecureShopDbContext
    {
        public SecureShopDbContext(DbContextOptions<SecureShopDbContext> options)
            : base(options)
        {
        }

       public DbSet<Feedback> Feedback { get; set; } = null!;
    }
}
