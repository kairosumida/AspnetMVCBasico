using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula09.Models
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Cidade")]
        public string Cidades { get; set; }
        public string Estado { get; set; }
    }
}