using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula10.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Favor preencher o nome!")]
        [StringLength(20, ErrorMessage ="O nome deve ter de 5 a 20 caracteres", MinimumLength =5)]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Favor preemcjer p CEP!")]
        [RegularExpression(@"\d{5}-\d{3}|\d{8}", ErrorMessage ="Utilize o formato 00000-000")]
        public string CEP { get; set; }
        [EmailAddress(ErrorMessage = "Email incorreto")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Nascimento é de preenchimento obrigatório")]
        public DateTime DataNascimento { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar a senha")]
        [Compare("Senha", ErrorMessage = "A senha e a confirmação da senha são diferentes")]
        public string SenhaRepetir { get; set; }
    }
}