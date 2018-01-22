using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula05.Models
{
    public class Treinamento
    {
        [Key]
        public int Id { get; set; }
        public string NomeTreinamento { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public decimal Preco { get; set; }
        public decimal Desconto { get; set; }
        public string Local { get; set; }
    }
}