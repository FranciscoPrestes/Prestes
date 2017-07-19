using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Prestes.Cotacao.Domain.Entities.ValueObjects;

namespace Prestes.Cotacao.MVC.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(60, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [MaxLength(14, ErrorMessage = "CPF deve obedecer o formato XXX.XXX.XXX-XX")]
        [MinLength(14, ErrorMessage = "CPF deve obedecer o formato XXX.XXX.XXX-XX")]
        public CPF Cpf { get; set; }

       
        [MaxLength(16, ErrorMessage = "Celular deve obedecer o formato (XX) X XXXX-XXXX")]
        [MinLength(16, ErrorMessage = "Celular deve obedecer o formato (XX) X XXXX-XXXX")]
        public string Celular { get; set; }

        [MaxLength(15, ErrorMessage = "Celular deve obedecer o formato (XX) XXXX-XXXX")]
        [MinLength(15, ErrorMessage = "Celular deve obedecer o formato (XX) XXXX-XXXX")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public Email Email { get; set; }



        public static FornecedorViewModel MapearFornecedores(Domain.Entities.Fornecedor fornecedor)
        {
            return new FornecedorViewModel
            {
                Id = fornecedor.Id,
                Nome = fornecedor.Nome,
                Celular = fornecedor.Celular,
                Telefone = fornecedor.Telefone,
                Cpf = fornecedor.Cpf,
                Email = fornecedor.Email
            };
        }
    }
}