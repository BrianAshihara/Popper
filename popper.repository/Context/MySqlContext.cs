
using Microsoft.EntityFrameworkCore;
using popper.domain.Entities;
using popper.repository.Mapping;

namespace popper.repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Chamado>? Chamado { get; set; }
        public DbSet<Local>? Local { get; set; }
        public DbSet<Tecnico>? Tecnico { get; set; }
        public DbSet<TipoChamado>? TipoChamado { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Chamado>(new ChamadoMap().Configure);
            modelBuilder.Entity<Local>(new LocalMap().Configure);
            modelBuilder.Entity<Tecnico>(new TecnicoMap().Configure);
            modelBuilder.Entity<TipoChamado>(new TipoChamadoMap().Configure);
        }
    }
}