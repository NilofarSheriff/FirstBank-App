using Microsoft.AspNetCore.Mvc;
using FirstBank_App.Models;

namespace FirstBank_App.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Verify(Account A)
        {
            if (A.Name == "Nilo" && A.Password == "123")
            {
                ViewBag.Name=A.Name;
                return View("Verify");

            }
            else
            {
                return View("ErrorAc");
            }
            

        }
    }
}
