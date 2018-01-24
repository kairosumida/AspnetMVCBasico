using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula10.Models
{
    public class Aula10DbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}