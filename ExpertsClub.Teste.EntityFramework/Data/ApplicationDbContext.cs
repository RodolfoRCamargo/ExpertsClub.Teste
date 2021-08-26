using ExpertsClub.Teste.EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace ExpertsClub.Teste.EntityFramework.Data
{
    public class ApplicationDbContext : DbContext
    {
        #region Tabelas
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        #endregion

        #region Configuração
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=ExpertsClub;Integrated Security=true");
        }

        // Modelagem do Banco de Dados separado por Tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
        #endregion
    }
}
