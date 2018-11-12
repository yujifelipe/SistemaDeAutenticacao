using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeAutenticacao.Models
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("Insira o Email")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Insira a Senha")]
        public string Senha { get; set; }
    }
}
