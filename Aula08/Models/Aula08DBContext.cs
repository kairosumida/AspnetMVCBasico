using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula08.Models
{
    public class Aula08DBContext :DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}