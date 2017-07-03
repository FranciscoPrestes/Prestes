using AutoMapper;


namespace Talentos.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
//            Mapper.CreateMap<CandidatoViewModel, Candidato>();
//            Mapper.CreateMap<HabilidadeViewModel, Habilidade>();
        }
    }
}