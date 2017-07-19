using AutoMapper;
using Prestes.Cotacao.Domain.Entities;
using Prestes.Cotacao.Domain.Entities.ValueObjects;
using Prestes.Cotacao.MVC.ViewModels;

namespace Prestes.Cotacao.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            //comprador
            Mapper.CreateMap<CompradorViewModel, Comprador>()
                .ForMember(dto => dto.Email, src => src.MapFrom(email => email.Email))
                .ForMember(dto => dto.Cpf, src => src.MapFrom(cpf => cpf.Cpf))
                .ForMember(dto => dto.Empresa, src => src.Ignore());


            Mapper.CreateMap<CompradorViewModel, Email>()
                .ForMember(dto => dto.Value, src => src.MapFrom(email => email.Email));

            Mapper.CreateMap<CompradorViewModel, CPF>()
                .ForMember(dto => dto.Value, src => src.MapFrom(cpf => cpf.Cpf));

            //fornecedor

        }
    }
}