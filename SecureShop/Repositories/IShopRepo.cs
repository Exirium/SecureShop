using SecureShop.Models;

namespace SecureShop.Repositories
{
    public interface IShopRepo
    {
        public void AddFeedback(Feedback feedback);

        public List<Feedback> GetAllFeedback();
    }
}