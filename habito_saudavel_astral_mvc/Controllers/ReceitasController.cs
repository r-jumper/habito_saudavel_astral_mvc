using Microsoft.AspNetCore.Mvc;

namespace habito_saudavel_astral_mvc.Controllers
{
    public class ReceitasController : Controller
    {
		public IActionResult Cafe()
		{
			return View();
		}

		public IActionResult Almoco()
		{
			return View();
		}

		public IActionResult Jantar()
        {
            return View();
        }

		public IActionResult Lanche()
		{
			return View();
		}

		public IActionResult Nutritivo()
		{
			return View();
		}

		public IActionResult Sobremesa()
		{
			return View();
		}
	}
}
