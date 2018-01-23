using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula07.Models
{
    public class Aula07DbContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}