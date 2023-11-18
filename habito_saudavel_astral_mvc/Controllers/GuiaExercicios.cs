using Microsoft.AspNetCore.Mvc;

namespace habito_saudavel_astral_mvc.Controllers
{
	public class GuiaExercicios : Controller
	{
		public IActionResult Crescer()
		{
			return View();
		}
        public IActionResult Definir()
        {
            return View();
        }
    }
}
