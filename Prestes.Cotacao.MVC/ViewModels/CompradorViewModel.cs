using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        public virtual Empresa Empresa { get; set; }
    }
}