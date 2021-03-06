﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula11.Models
{
    public class Curso
    {
        [Key]
        public int CursoID { get; set; }
        [DisplayName("Curso")]
        public string Nome { get; set; }
        [Range(typeof(decimal), "1", "100000", ErrorMessage = "O preço deve de 1 a 100000")]
        [DisplayName("Preço")]
        public decimal Preco { get; set; }
    }
}