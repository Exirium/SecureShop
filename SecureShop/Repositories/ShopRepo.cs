using SecureShop.Data;
using SecureShop.Models;

namespace SecureShop.Repositories
{
    public class ShopRepo : IShopRepo
    {
        private readonly ISecureShopDbContext _dbContext;

        public ShopRepo(ISecureShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _dbContext.Feedback.Add(feedback);
            _dbContext.SaveChanges();
        }

        public List<Feedback> GetAllFeedback()
        {
            return _dbContext.Feedback.ToList();
        }
    }
}
