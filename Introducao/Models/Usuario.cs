using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Introducao.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O Nome é obrigatório!")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "O texto deve ter de 5 a 50 caracteres!")]
        public string Observacoes { get; set; }

        [Range(18, 70, ErrorMessage = "A idade tem que estar de 18 a 70 anos!")]
        public int Idade { get; set; }

        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Digite um email válido!")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres!")]
        [Required(ErrorMessage = "O Login é obrigatório!")]
        [Remote("LoginUnico","Usuario", ErrorMessage = "Este login já existe")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória!")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage ="As senhas são diferentes!")]
        public string ConfirmarSenha { get; set; }
    }
}