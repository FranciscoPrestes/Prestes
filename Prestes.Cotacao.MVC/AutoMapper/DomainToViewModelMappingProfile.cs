using AutoMapper;
using Prestes.Cotacao.Domain.Entities;
using Prestes.Cotacao.Domain.Entities.ValueObjects;
using Prestes.Cotacao.MVC.ViewModels;


namespace Talentos.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            //comprador
            Mapper.CreateMap<Comprador, CompradorViewModel>()
                .ForMember(dto => dto.Email, src => src.MapFrom(email => email.Email.Value))
                .ForMember(dto => dto.Cpf, src => src.MapFrom(cpf => cpf.Cpf.Value));

            Mapper.CreateMap<Comprador, Email>()
                .ForMember(dto => dto.Value, src => src.MapFrom(email => email.Email.Value));

            Mapper.CreateMap<Comprador, CPF>()
                .ForMember(dto => dto.Value, src => src.MapFrom(cpf => cpf.Cpf.Value));



            //Fornecedor
        }
    }
}