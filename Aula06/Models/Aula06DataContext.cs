using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula06.Models
{
    public class Aula06DataContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
    }
}