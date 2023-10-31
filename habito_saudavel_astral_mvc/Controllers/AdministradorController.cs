using Microsoft.AspNetCore.Mvc;

namespace habito_saudavel_astral_mvc.Controllers
{
	public class AdministradorController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}

		public IActionResult Cadastro()
		{
			return View();
		}
		public IActionResult Autentic()
		{
			return View();
		}
	}
}
