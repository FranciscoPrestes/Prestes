using System.Collections.Generic;

namespace Prestes.Cotacao.Domain.Entities.ValueObjects
{
    public class EstadosBrasileiros
    {
        public string Nome { get; set; }
        public string Abreviacao { get; set; }

        public static IEnumerable<EstadosBrasileiros> ObtemEstados()
        {
            return new List<EstadosBrasileiros>()
            {
                new EstadosBrasileiros(){Nome = "Acre", Abreviacao = "AC"},
                new EstadosBrasileiros(){Nome = "Alagoas", Abreviacao = "AL"},
                new EstadosBrasileiros(){Nome = "Amapá", Abreviacao = "AP"},
                new EstadosBrasileiros(){Nome = "Amazonas", Abreviacao = "AM"},
                new EstadosBrasileiros(){Nome = "Bahia", Abreviacao = "BA"},
                new EstadosBrasileiros(){Nome = "Ceará", Abreviacao = "CE"},
                new EstadosBrasileiros(){Nome = "Distrito Federal", Abreviacao = "DF"},
                new EstadosBrasileiros(){Nome = "Espírito Santo", Abreviacao = "ES"},
                new EstadosBrasileiros(){Nome = "Goiás", Abreviacao = "GO"},
                new EstadosBrasileiros(){Nome = "Maranhão", Abreviacao = "MA"},
                new EstadosBrasileiros(){Nome = "Mato Grosso", Abreviacao = "MT"},
                new EstadosBrasileiros(){Nome = "Mato Grosso do Sul", Abreviacao = "MS"},
                new EstadosBrasileiros(){Nome = "Minas Gerais", Abreviacao = "MG"},
                new EstadosBrasileiros(){Nome = "Pará", Abreviacao = "PA"},
                new EstadosBrasileiros(){Nome = "Paraíba", Abreviacao = "PB"},
                new EstadosBrasileiros(){Nome = "Paraná", Abreviacao = "PR"},
                new EstadosBrasileiros(){Nome = "Pernambuco", Abreviacao = "PE"},
                new EstadosBrasileiros(){Nome = "Piauí", Abreviacao = "PI"},
                new EstadosBrasileiros(){Nome = "Rio de Janeiro", Abreviacao = "RJ"},
                new EstadosBrasileiros(){Nome = "Rio Grande do Norte", Abreviacao = "RN"},
                new EstadosBrasileiros(){Nome = "Rio Grande do Sul", Abreviacao = "RS"},
                new EstadosBrasileiros(){Nome = "Rondônia", Abreviacao = "RO"},
                new EstadosBrasileiros(){Nome = "Roraima", Abreviacao = "RR"},
                new EstadosBrasileiros(){Nome = "Santa Catarina", Abreviacao = "SC"},
                new EstadosBrasileiros(){Nome = "São Paulo", Abreviacao = "SP"},
                new EstadosBrasileiros(){Nome = "Sergipe", Abreviacao = "SE"},
                new EstadosBrasileiros(){Nome = "Tocantins", Abreviacao = "TO"}
            };
        }
    }
}
