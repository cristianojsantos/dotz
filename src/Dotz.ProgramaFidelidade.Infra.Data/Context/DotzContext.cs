using Dotz.ProgramaFidelidade.Domain.Models;
using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;
using Dotz.ProgramaFidelidade.Domain.Models.PedidoContext;
using Dotz.ProgramaFidelidade.Domain.Models.PontuacaoContext;
using Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext;
using Dotz.ProgramaFidelidade.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Dotz.ProgramaFidelidade.Infra.Data.Context
{
    public class DotzContext: DbContext
    {
        public DotzContext(DbContextOptions<DotzContext> options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ClienteEndereco> ClienteEndereco { get; set; }
        public DbSet<ClienteTelefoneContato> ClienteTelefoneContato { get; set; }
        public DbSet<PedidoResgate> PedidoResgate { get; set; }
        public DbSet<PedidoResgateItem> PedidoResgateItem { get; set; }
        public DbSet<PontuacaoCliente> PontuacaoCliente { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
        public DbSet<TipoEndereco> TipoEndereco { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Padronização de Tipos nas configurações de Entidades

            foreach (var property in modelBuilder
              .Model
              .GetEntityTypes()
              .SelectMany(
                 e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");

            }

            foreach (var property in modelBuilder
              .Model
              .GetEntityTypes()
              .SelectMany(
                 e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(DateTime))))
            {
                property.SetColumnType("date");
            }

            foreach (var property in modelBuilder
              .Model
              .GetEntityTypes()
              .SelectMany(
                 e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(Nullable<DateTime>))))
            {
                property.SetColumnType("date");
            }

            foreach (var property in modelBuilder
              .Model
              .GetEntityTypes()
              .SelectMany(
                 e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(decimal))))
            {
                property.SetColumnType("numeric(10,2)");
                property.SetDefaultValue(0);
            }

            foreach (var property in modelBuilder
              .Model
              .GetEntityTypes()
              .SelectMany(
                 e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(Nullable<int>))))
            {
                property.SetColumnType("int");
            }

            foreach (var property in modelBuilder
              .Model
              .GetEntityTypes()
              .SelectMany(
                 e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(int))))
            {
                property.SetColumnType("int");
            }

            foreach (var property in modelBuilder
              .Model
              .GetEntityTypes()
              .SelectMany(
                 e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(Nullable<decimal>))))
            {
                property.SetColumnType("numeric(10,2)");
            }

            foreach (var property in modelBuilder
              .Model
              .GetEntityTypes()
              .SelectMany(
                 e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(Nullable<float>))))
            {
                property.SetColumnType("numeric(10,2)");
            }

            foreach (var property in modelBuilder
              .Model
              .GetEntityTypes()
              .SelectMany(
                 e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(float))))
            {
                property.SetColumnType("numeric(10,2)");
                property.SetDefaultValue(0);
            }

            foreach (var property in modelBuilder
              .Model
              .GetEntityTypes()
              .SelectMany(
                 e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(Nullable<bool>))))
            {
                property.SetColumnType("bit");
                property.SetDefaultValue(false);
            }

            foreach (var property in modelBuilder
              .Model
              .GetEntityTypes()
              .SelectMany(
                 e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(bool))))
            {
                property.SetColumnType("bit");
                property.SetDefaultValue(false);
            }

            #endregion

            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ClienteEnderecoMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ClienteTelefoneContatoMap());
            modelBuilder.ApplyConfiguration(new PedidoResgateItemMap());
            modelBuilder.ApplyConfiguration(new PedidoResgateMap());
            modelBuilder.ApplyConfiguration(new PontuacaoClienteMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new SubCategoriaMap());
            modelBuilder.ApplyConfiguration(new TipoEnderecoMap());
            modelBuilder.ApplyConfiguration(new TipoTelefoneContatoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
