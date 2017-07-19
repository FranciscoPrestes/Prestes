using Prestes.Cotacao.Application.Interfaces;
using Prestes.Cotacao.Domain.Interfaces.Services;

namespace Prestes.Cotacao.Application.Services
{
    public class FornecedorAppService : AppServiceBase<Domain.Entities.Fornecedor>, IFornecedorAppService
    {
        private readonly IFornecedorService _fornecedorService;
        public FornecedorAppService(IFornecedorService fornecedorService) : base(fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }
    }
}
