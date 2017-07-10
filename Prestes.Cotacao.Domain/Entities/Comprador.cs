using System;
using Prestes.Cotacao.Domain.Entities.ValueObjects;

namespace Prestes.Cotacao.Domain.Entities
{
    public class Comprador
    {
        public int CampradorId  { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public CPF Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
