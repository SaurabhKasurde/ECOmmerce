using Microsoft.AspNetCore.Mvc;

namespace ECOmmerce.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
