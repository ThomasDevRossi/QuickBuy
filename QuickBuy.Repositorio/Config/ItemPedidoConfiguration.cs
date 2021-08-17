using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder
                .HasKey(k => k.Id);
            builder
                .Property(p => p.ProdutoId)
                .IsRequired();
            builder
                .Property(p => p.Quantidade)
                .IsRequired();
        }
    }
}
