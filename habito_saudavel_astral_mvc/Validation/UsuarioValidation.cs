using FluentValidation;
using habito_saudavel_astral_mvc.Models;
using System.ComponentModel.DataAnnotations;

namespace habito_saudavel_astral_mvc.Validation
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator() {
            RuleFor(Usuario => Usuario.Id).NotNull();
            RuleFor(Usuario => Usuario.Name).NotNull();
            RuleFor(Usuario => Usuario.Email).EmailAddress();
            RuleFor(Usuario => Usuario.Senha).NotNull();


        }

        internal ValidationResult Validate(object usuario)
        {
            throw new NotImplementedException();
        }
    }
}
