using Microsoft.AspNetCore.Mvc;

namespace habito_saudavel_astral_mvc.Controllers
{
    public class AlimentacaoController : Controller
    {
        public IActionResult Receitas()
        {
            return View();
        }

		public IActionResult Grupos()
		{
			return View();
		}
		public IActionResult Refeicoes()
		{
			return View();
		}
	}
}
