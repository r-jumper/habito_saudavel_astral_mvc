using habito_saudavel_astral_mvc.Models;
using habito_saudavel_astral_mvc.Validation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace habito_saudavel_astral_mvc.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Login()
		{
            
            Usuario Usuario = new();
            
            UsuarioValidator validator = new();

            ValidationResult results = validator.Validate(Usuario);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }
            return View();
		}

		public IActionResult Cadastro()
		{
			return View();
		}
        public IActionResult Contato()
        {
            return View();
        }
    }
}
