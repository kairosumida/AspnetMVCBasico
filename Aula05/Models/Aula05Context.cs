using System.Data.Entity;

namespace Aula05.Models
{
    public class Aula05Context : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

    }
}