using EFWindowsForm.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace EFWindowsForm.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UsuarioModel> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
