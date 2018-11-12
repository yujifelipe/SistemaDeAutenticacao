using Microsoft.AspNetCore.Mvc;
using SistemaDeAutenticacao.Models;

namespace SistemaDeAutenticacao.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            return View();
        }
    }
}
