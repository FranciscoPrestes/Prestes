using System.Collections;
using Prestes.Cotacao.Application.Interfaces;
using Prestes.Cotacao.Domain.Entities;
using Prestes.Cotacao.Domain.Interfaces.Services;

namespace Prestes.Cotacao.Application.Services
{
    public class CompradorAppService : AppServiceBase<Comprador>, ICompreadorAppService
    {
        private readonly ICompradorService _compradorService;

        public CompradorAppService(ICompradorService compradorService) : base(compradorService)
        {
            _compradorService = compradorService;
        }

       
    }
}
