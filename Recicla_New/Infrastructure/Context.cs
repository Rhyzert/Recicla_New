using System.Collections.Generic;
using System.Reflection.Emit;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class SqlContext : DbContext
    {

        //https://balta.io/blog/ef-crud
        //https://jasonwatmore.com/post/2022/03/18/net-6-connect-to-sql-server-with-entity-framework-core

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ReciclaNew");
        }

 

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Caminhao> Caminhoes { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<ItemColetado> ItensColetados { get; set; }
        public DbSet<Coleta> Coletas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Coletador> Coletadores { get; set; }
        public DbSet<TipoReciclavel> TipoReciclaveis { get; set; }
        public DbSet<Lixo> Lixos { get; set; }
    }
}
