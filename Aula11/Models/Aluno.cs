using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula11.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string NomeAluno { get; set; }
        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get;set; }

    }
}