using Microsoft.AspNetCore.Mvc;

namespace API_Gusmus.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
