﻿using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento()
                {
                    Id = 1,
                    Nome = "Boleto",
                    Descricao = "Forma de Pagamento Boleto"
                },
                new FormaPagamento()
                {
                    Id = 2,
                    Nome = "CartaoCredito",
                    Descricao = "Forma de Pagamento Cartão Crédito"
                },
                new FormaPagamento()
                {
                    Id = 3,
                    Nome = "Deposito",
                    Descricao = "Forma de Pagamento Depósito"
                });

            base.OnModelCreating(modelBuilder);
        }

    }
}
