using Microsoft.EntityFrameworkCore;
using PrimeiroEFMVC.Models;

namespace PrimeiroEFMVC.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base (options)
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }

    }
}
