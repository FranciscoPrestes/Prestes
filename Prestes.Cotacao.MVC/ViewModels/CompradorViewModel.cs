using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Prestes.Cotacao.Application.Services;
using Prestes.Cotacao.Domain.Entities;
using Prestes.Cotacao.Domain.Entities.ValueObjects;

namespace Prestes.Cotacao.MVC.ViewModels
{
    public class CompradorViewModel
    {
        [Key]
        public int CampradorId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(60, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [MaxLength(14, ErrorMessage = "CPF deve obedecer o formato XXX.XXX.XXX-XX")]
        [MinLength(14, ErrorMessage = "CPF deve obedecer o formato XXX.XXX.XXX-XX")]
        public string Cpf { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        [DisplayName("Empresa")]
        public int EmpresaId { get; set; }
        public string EmpresaNome { get; set; }
        public IEnumerable Empresas { get; set; }

        //Decidi mapear o objeto ao inves de usar tecnologias como AutoMapper
        //para ter mais liberdade ao manipular a complexidade do domínio.
        public static IEnumerable<CompradorViewModel> ModelToViewModel(IEnumerable<Comprador> compradores)
        {
            return compradores.Select(comprador => new CompradorViewModel()
            {
                CampradorId = comprador.CampradorId,
                Nome = comprador.Nome,
                Cpf = comprador.Cpf.Value,
                Email = comprador.Email.Value,
                DataCadastro = comprador.DataCadastro,
                EmpresaId = comprador.Empresa.EmpresaId,
                EmpresaNome = comprador.Empresa.NomeFantasia
            });
        }

        internal static CompradorViewModel ModelToViewModel(Comprador comprador, EmpresaAppService empresaApp)
        {
            var compradorView = ModelToViewModel(comprador);
            compradorView.Empresas = empresaApp.GetAll();

            return compradorView;
        }

        public static CompradorViewModel ModelToViewModel(Comprador comprador)
        {
            if (0 == comprador.CampradorId)
            {
                comprador.Email = new Email();
                comprador.Cpf = new CPF();
                comprador.Empresa = new Empresa();
            }

            return new CompradorViewModel()
            {
                CampradorId = comprador.CampradorId,
                Nome = comprador.Nome,
                Cpf = comprador.Cpf.Value,
                Email = comprador.Email.Value,
                DataCadastro = comprador.DataCadastro,
                EmpresaId = comprador.Empresa.EmpresaId,
                EmpresaNome = comprador.Empresa?.NomeFantasia
            };
        }

        public static IEnumerable<Comprador> ViewModelToModel(IEnumerable<CompradorViewModel> compradoresViewModel)
        {
            return compradoresViewModel.Select(compradorView => new Comprador()
            {
                CampradorId = compradorView.CampradorId,
                Nome = compradorView.Nome,
                Cpf = new CPF() { Value = compradorView.Cpf },
                Email = new Email() { Value = compradorView.Email },
                EmpresaId = compradorView.EmpresaId,
                DataCadastro = compradorView.DataCadastro
            });
        }

        public static Comprador ViewModelToModel(CompradorViewModel compradoresViewModel)
        {
            return new Comprador()
            {
                CampradorId = compradoresViewModel.CampradorId,
                Nome = compradoresViewModel.Nome,
                Cpf = new CPF() { Value = compradoresViewModel.Cpf },
                Email = new Email() { Value = compradoresViewModel.Email },
                EmpresaId = compradoresViewModel.EmpresaId,
                DataCadastro = compradoresViewModel.DataCadastro
            };
        }


    }
}