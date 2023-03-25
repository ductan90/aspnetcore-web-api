using Microsoft.AspNetCore.Mvc;

namespace my_books.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
