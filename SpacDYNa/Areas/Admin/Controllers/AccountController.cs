using Microsoft.AspNetCore.Mvc;

namespace SpacDYNa.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
