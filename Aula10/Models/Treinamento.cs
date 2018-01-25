using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula10.Models
{
    public class Treinamento
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Treinamento")]
        [Required(ErrorMessage="Favor colocar o nome do treinamento!")]
        [StringLength(30,ErrorMessage ="O treinamento deve ter de 2 a 30 caracteres",MinimumLength =2)]
        public string NomeTreinamento { get; set; }
        [DisplayName("Início")]
        public DateTime Inicio { get; set; }
        [DisplayName("Término")]
        public DateTime Termino { get; set; }
        [DisplayName("Preço")]
        [Range(typeof(decimal), "10", "1000", ErrorMessage ="O preço deve de 10 a 1000")]
        public decimal Preco { get; set; }
        [Range(typeof(decimal), "0", "100", ErrorMessage = "O desconto deve ser de 0 a 100")]
        public decimal Desconto { get; set; }
        [Required(ErrorMessage ="Local deve ser preenchido")]
        [RegularExpression(@"[ABC]", ErrorMessage = "Digite apenas A, B ou C")]
        public string Local { get; set; }
    }
}