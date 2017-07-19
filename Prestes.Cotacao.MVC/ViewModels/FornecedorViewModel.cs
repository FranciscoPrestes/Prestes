using Prestes.Cotacao.Domain.Entities.ValueObjects;

namespace Prestes.Cotacao.MVC.ViewModels
{
    public class FornecedorViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public CPF Cpf { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public Email Email { get; set; }
    }
}