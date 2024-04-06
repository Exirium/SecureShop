using Microsoft.EntityFrameworkCore;
using SecureShop.Models;

namespace SecureShop.Data
{
     public interface ISecureShopDbContext
    {
        public DbSet<Feedback> Feedback { get; set; }

        int SaveChanges();
    }
}