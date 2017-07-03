using System.Data.Entity.ModelConfiguration;
using Prestes.Cotacao.Domain.Entities;

namespace Prestes.Cotacao.Infra.Data.EntityConfig
{
    public class CompradorConfiguration : EntityTypeConfiguration<Comprador>
    {
        public CompradorConfiguration()
        {
            HasKey(c => c.CampradorId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(60);

            Property(c => c.Email.Endereco)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Cpf.Cpf)
                .IsRequired()
                .HasMaxLength(14);

        }
    }
}
