using Prestes.Cotacao.Domain.Entities;
using Prestes.Cotacao.Domain.Interfaces.Repository;
using Prestes.Cotacao.Domain.Interfaces.Services;

namespace Prestes.Cotacao.Domain.Services
{
    public class EmpresaService : ServiceBase<Empresa>, IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaService(IEmpresaRepository empresaRepository) : base(empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
    }
}
