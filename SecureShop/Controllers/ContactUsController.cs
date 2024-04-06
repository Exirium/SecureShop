using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SecureShop.Models;
using SecureShop.Repositories;

namespace SecureShop.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IShopRepo _repo;
        private readonly UserManager<IdentityUser> _userManager;

        public ContactUsController(IShopRepo repo, UserManager<IdentityUser> userManager)
        {
            _repo = repo;
            _userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SubmitFeedback(FeedbackViewModel feedback)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var processedFeedback = new Feedback
            {
                Subject = feedback.Subject,
                Comment = feedback.Comment,
                UserName = user.UserName
            };
            _repo.AddFeedback(processedFeedback);
            return RedirectToAction("Index");
        }

        [Authorize]
        [HttpGet]
        public IActionResult ViewFeedback()
        {
            var feedbackList = _repo.GetAllFeedback();
            return View(feedbackList);
        }
    }
}
