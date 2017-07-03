namespace Prestes.Cotacao.Domain.Entities.ValueObjects
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; } //string pois pode ser 142 A, por exmplo
        public string Bairro { get; set; }
        protected string Cep { get; set; }
        public string Cidade { get; set; }
        public EstadosBrasileiros Estado { get; set; }
    }
}
