using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using ProdutosApp.Mappings;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProdutosApp.Contexts
{
    public class DataContext : DbContext
    {
        //método para configurar a conexão com banco de dados do SQLServer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost, 1434; Initial Catalog = master; Persist Security Info = True; User ID = sa; Password = Coti@2025; Encrypt = False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }
    }
    

}
