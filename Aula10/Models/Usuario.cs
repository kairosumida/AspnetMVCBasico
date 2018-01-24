using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula10.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
        public string SenhaRepetir { get; set; }
    }
}