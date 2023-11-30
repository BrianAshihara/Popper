using System.Text.Json;
using popper.domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace popper.teste
{
    [TestClass]
    public class UnitTestRepository

    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Usuario> Usuario { get; set; }
            public DbSet<Chamado> Chamado { get; set; }
            public DbSet<Local> Local { get; set; }
            public DbSet<Tecnico> Tecnico { get; set; }
            public DbSet<TipoChamado> TipoChamado { get; set; }
            public MyDbContext()
            {

                //Database.EnsureCreated();

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "popper";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            }
        }

        [TestMethod]
        public void TestInsertUsuario()
        {
            using (var context = new MyDbContext())
            {

                var usuario = new Usuario
                {
                    Nome = "Murilo",
                    Endereco = "tonsig"
                };
                context.Usuario.Add(usuario);

                usuario = new Usuario
                {
                    Nome = "João",
                    Endereco = "galo"
                };
                context.Usuario.Add(usuario);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListarUsuario()
        {
            using (var context = new MyDbContext())
            {
                foreach (var usuario in context.Usuario)
                {
                    Console.WriteLine(JsonSerializer.Serialize(usuario));
                }
            }
        }
    }
}
