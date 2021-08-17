using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder
                .HasKey(k => k.Id);
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
