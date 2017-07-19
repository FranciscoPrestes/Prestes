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

            Property(c => c.Email.Value)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Cpf.Value)
                .IsRequired()
                .HasMaxLength(14);

            Property(c=> c.EmpresaId).IsRequired();

        }
    }
}
