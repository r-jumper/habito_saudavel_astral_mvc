using habito_saudavel_astral_mvc.Enums;

namespace habito_saudavel_astral_mvc.Models
{
	public class Usuario
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Login { get; set;}
		
        public string Email { get; set; }
        public string Senha { get; set;}

		public DateTime DataDeCadastro { get; set;}

		public DateTime? DataDeAlteracao { get; set;}

		public PerfilEnum Perfil { get; set;}

		
	}
}
