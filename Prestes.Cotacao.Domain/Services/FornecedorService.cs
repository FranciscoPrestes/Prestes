using Prestes.Cotacao.Domain.Entities;
using Prestes.Cotacao.Domain.Interfaces.Repository;
using Prestes.Cotacao.Domain.Interfaces.Services;

namespace Prestes.Cotacao.Domain.Services
{
    public class FornecedorService : ServiceBase<Fornecedor>, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedoresRepository;
        public FornecedorService(IFornecedorRepository fornecedoresRepository) : base(fornecedoresRepository)
        {
            _fornecedoresRepository = fornecedoresRepository;
        }
    }
}
