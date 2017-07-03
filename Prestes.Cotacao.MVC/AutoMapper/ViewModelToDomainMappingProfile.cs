using AutoMapper;

namespace Prestes.Cotacao.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
//            Mapper.CreateMap<Candidato, CandidatoViewModel>();
//            Mapper.CreateMap<Habilidade, HabilidadeViewModel>();
        }
    }
}