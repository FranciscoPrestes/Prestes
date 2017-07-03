using Prestes.Cotacao.Application.Interfaces;
using Prestes.Cotacao.Domain.Entities;
using Prestes.Cotacao.Domain.Interfaces.Services;

namespace Prestes.Cotacao.Application.Services
{
    public class EmpresaAppService:AppServiceBase<Empresa>, IEmpresaAppService
    {
        private readonly IEmpresaService _empresaService;

        public EmpresaAppService(IEmpresaService empresaService) : base(empresaService)
        {
            _empresaService = empresaService;
        }
    }
}
