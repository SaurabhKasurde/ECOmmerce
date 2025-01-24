using Microsoft.AspNetCore.Mvc;

namespace ECOmmerce.Controllers.Login_Controller
{
    public class AdminLoginController : Controller
    {

        #region Parameters
        #endregion

        #region Constructor
        public AdminLoginController() 
        {

        }

        #endregion

        #region ActionMethod
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult adminLogin()
        {
            return View();
        }
        #endregion
    }
}
