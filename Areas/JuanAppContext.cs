﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Areas.JuanApp.EntitiesConfiguration;
using JuanApp.Areas.BasicCore.Entities;
using JuanApp.Areas.BasicCore.Entities.EntitiesConfiguration;

namespace JuanApp.Areas.BasicCore
{
    public class JuanAppContext : DbContext
    {
        protected IConfiguration _configuration { get; }

        public DbSet<Failure> Failure { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Remito> Remito { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Salida> Salida { get; set; }

        public JuanAppContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                string ConnectionString = "";

                ConnectionString = "data source =.; " +
                   "initial catalog = JuanApp; " +
                   "Integrated Security = SSPI;" +
                   " MultipleActiveResultSets=True;" +
                   "Pooling=false;" +
                   "Persist Security Info=True;" +
                   "App=EntityFramework;" +
                   "TrustServerCertificate=True;";

                optionsBuilder
                    .UseSqlServer(ConnectionString);
            }
            catch (Exception) { throw; }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                modelBuilder.ApplyConfiguration(new FailureConfiguration());
                modelBuilder.ApplyConfiguration(new ProductoConfiguration());
                modelBuilder.ApplyConfiguration(new RemitoConfiguration());
                modelBuilder.ApplyConfiguration(new ClienteConfiguration());
                modelBuilder.ApplyConfiguration(new EntradaConfiguration());
                modelBuilder.ApplyConfiguration(new SalidaConfiguration());
            }
            catch (Exception) { throw; }
        }
    }
}
