using System.Data.Entity.ModelConfiguration;
using Prestes.Cotacao.Domain.Entities;

namespace Prestes.Cotacao.Infra.Data.EntityConfig
{
    public class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguration()
        {
            HasKey(fornecedor => fornecedor.Id);

            Property(fornecedor => fornecedor.Nome)
                .IsRequired()
                .HasMaxLength(60);

            Property(fornecedor => fornecedor.Email.Endereco)
                .IsRequired()
                .HasMaxLength(100);

            Property(fornecedor => fornecedor.Cpf.Cpf)
                .IsRequired()
                .HasMaxLength(14);

            Property(fornecedor => fornecedor.Celular)
                .HasMaxLength(14);

            Property(fornecedor => fornecedor.Telefone)
                .HasMaxLength(14);
        }
    }
}
