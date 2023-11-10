using Microsoft.AspNetCore.Mvc;

namespace habito_saudavel_astral_mvc.Controllers
{
    public class PerfilController : Controller
    {
        public IActionResult Perfil()
        {
            return View();
        }

        public IActionResult Alimentação()
        {
            return View();
        }

        public IActionResult Treino()
        {
            return View();
        }

        public IActionResult Monitor()
        {
            return View();
        }
    }
}
