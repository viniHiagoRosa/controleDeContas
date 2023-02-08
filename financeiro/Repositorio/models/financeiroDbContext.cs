

using Microsoft.EntityFrameworkCore;

namespace financeiro.Repositorio.models
{
    public class financeiroDbContext : DbContext
    {
        public financeiroDbContext(DbContextOptions<financeiroDbContext> options) : base(options) { }

        public DbSet<ControleDeContas> ControleDeContas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var controleBuilder = modelBuilder.Entity<ControleDeContas>();
            controleBuilder.HasKey(x => x.Id);
        }
    }
}
