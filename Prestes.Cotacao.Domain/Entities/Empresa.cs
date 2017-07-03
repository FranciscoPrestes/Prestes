using System;
using Prestes.Cotacao.Domain.Entities.ValueObjects;

namespace Prestes.Cotacao.Domain.Entities
{
    public class Empresa
    {
        public int EmpresaId { get; set; }

        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public Endereco Endereco { get; set; }
        public CNPJ Cnpj { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}