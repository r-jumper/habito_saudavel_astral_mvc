using Microsoft.AspNetCore.Mvc;

namespace habito_saudavel_astral_mvc.Controllers
{
    public class ReceitasController : Controller
    {
        public IActionResult Jantar()
        {
            return View();
        }
    }
}
