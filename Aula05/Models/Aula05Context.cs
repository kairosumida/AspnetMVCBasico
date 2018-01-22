using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula05.Models
{
    public class Aula05Context : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

    }
}