using IBM.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationMVC1.Mappings;
using WebApplicationMVC1.Models;

namespace WebApplicationMVC1.Context
{ 
    public class InformixContext : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Estado> Estados { get; set; } 

        public DbSet<Pais> Paises { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=127.0.0.1:5125;Database=banco;Uid=tiwebapps;Pwd=senha;";

            optionsBuilder.UseDb2(connectionString, options => options.SetServerInfo(IBMDBServerType.IDS, IBMDBServerVersion.IDS_11_70_8000));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CidadeConfiguration());
            modelBuilder.ApplyConfiguration(new EstadoConfiguration());
            modelBuilder.ApplyConfiguration(new PaisConfiguration());
        }

    } 
}