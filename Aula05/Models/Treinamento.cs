using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula05.Models
{
    public class Treinamento
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Treinamento")]
        public string NomeTreinamento { get; set; }
        [DisplayName("Início")]
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        [DisplayName("Preço")]
        public decimal Preco { get; set; }
        public decimal Desconto { get; set; }
        public string Local { get; set; }
    }
}