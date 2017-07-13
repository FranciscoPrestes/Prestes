using System;
using System.ComponentModel.DataAnnotations;
using Prestes.Cotacao.Domain.Entities.ValueObjects;

namespace Prestes.Cotacao.MVC.ViewModels
{
    public class EmpresaViewModel
    {
        [Key]
        public int EmpresaId { get; set; }


        [Required(ErrorMessage = "Preencha a razão social da empresa.")]
        [MaxLength(60, ErrorMessage = "Máximo {0} caracteres.")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Preencha o nome fantasia da empresa.")]
        [MaxLength(60, ErrorMessage = "Máximo {0} caracteres")]
        public string NomeFantasia { get; set; }
        
        
        [Required(ErrorMessage = "Preencha o CNPJ.")]
        [MaxLength(18, ErrorMessage = "CNPJ deve obedecer o formato XX.XXX.XXX/XXXX-XX")]
        [MinLength(18, ErrorMessage = "CNPJ deve obedecer o formato XX.XXX.XXX/XXXX-XX")]
        public string Cnpj { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Preencha a rua.")]
        [MaxLength(60, ErrorMessage = "Máximo {0} caracteres.")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Preencha o número.")]
        [MaxLength(12, ErrorMessage = "Máximo {0} caracteres.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Preencha o bairro.")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Preencha o CEP.")]
        [MaxLength(18, ErrorMessage = "CEP deve obedecer o formato XXXXX-XXX")]
        [MinLength(18, ErrorMessage = "CEP deve obedecer o formato XXXXX-XXX")]
        protected string Cep { get; set; }

        [Required(ErrorMessage = "Preencha a cidade.")]
        [MaxLength(40, ErrorMessage = "Máximo {0} caracteres")]
        public string Cidade { get; set; }
        public string EstadoAbreviacao { get; set; }

    }
}