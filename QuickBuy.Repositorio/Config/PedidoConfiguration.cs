using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder
                .HasKey(k => k.Id);
            builder
                .Property(p => p.DataPedido)
                .IsRequired();
            builder
                .Property(p => p.UsuarioId)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired();
            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
