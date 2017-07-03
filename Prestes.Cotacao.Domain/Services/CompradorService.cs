using Prestes.Cotacao.Domain.Entities;
using Prestes.Cotacao.Domain.Interfaces.Repository;
using Prestes.Cotacao.Domain.Interfaces.Services;

namespace Prestes.Cotacao.Domain.Services
{
    public class CompradorService:ServiceBase<Comprador>,ICompradorService
    {

        private readonly ICompradorRepository _compradorRepository;

        public CompradorService(ICompradorRepository compradorRepository) : base(compradorRepository)
        {
            _compradorRepository = compradorRepository;
        }
    }
}
