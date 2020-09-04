using Microsoft.EntityFrameworkCore;
using ProjectDDD.Domain.Entities;
using System;
using System.Linq;

namespace ProjectDDD.Infra.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Estoque> Estoques { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Estoque>().ToTable("Estoque");

            modelBuilder.Entity<Cliente>().HasKey(c => c.Codigo);
            modelBuilder.Entity<Estoque>().HasKey(c => c.Codigo);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Cadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Cadastro").CurrentValue = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Property("Cadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
