using System.Data.Entity.ModelConfiguration;
using Prestes.Cotacao.Domain.Entities;

namespace Prestes.Cotacao.Infra.Data.EntityConfig
{
    public class EmpresaConfiguration : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfiguration()
        {
            HasKey(c => c.EmpresaId);

            Property(c => c.NomeFantasia)
                .IsRequired()
                .HasMaxLength(60);

            Property(c => c.RazaoSocial)
                .IsRequired()
                .HasMaxLength(60);

            Property(c => c.Endereco.Bairro)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Endereco.Numero)
                .IsRequired()
                .HasMaxLength(12);

            Property(c => c.Endereco.Cidade)
                .IsRequired()
                .HasMaxLength(40);

            Property(c => c.Endereco.Rua)
                .IsRequired()
                .HasMaxLength(60);

            Property(c => c.Endereco.Estado.Abreviacao)
                .IsRequired()
                .HasMaxLength(2);

            Property(c => c.Endereco.Estado.Nome)
                .IsRequired()
                .HasMaxLength(30);

            Property(c => c.Cnpj.Cnpj)
                .IsRequired()
                .HasMaxLength(18);
        }
    }
}
