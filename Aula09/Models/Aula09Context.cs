using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Aula09.Models
{
    public class Aula09Context : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}