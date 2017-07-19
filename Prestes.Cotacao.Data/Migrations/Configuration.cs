using System.Linq;
using Prestes.Cotacao.Domain.Entities;
using Prestes.Cotacao.Domain.Entities.ValueObjects;

namespace Prestes.Cotacao.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Prestes.Cotacao.Infra.Data.Context.CotacaoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Prestes.Cotacao.Infra.Data.Context.CotacaoContext context)
        {
            //empresa
            var empresa = new Empresa()
            {
                EmpresaId = 1,
                RazaoSocial = "Mega Compras LTDA",
                NomeFantasia = "Mega Compras",
                Cnpj = new CNPJ() { Value = "12.345.678/0001-91" },
                Endereco = new Endereco()
                {
                    Bairro = "Centro",
                    Cidade = "Campo Grande",
                    Estado = EstadosBrasileiros.ObtemEstados().FirstOrDefault(e => e.Abreviacao == "MS"),
                    Numero = "123",
                    Rua = "Rua Central",
                    Cep = "79041-000"
                }

            };



            context.Empresas.AddOrUpdate(p => p.EmpresaId, empresa);

            //compradores
            context.Compradores.AddOrUpdate(
                p => p.Nome,
                new Comprador()
                {
                    Nome = "Francisco Prestes",
                    Cpf = new CPF() { Value = "022.762.731-86" },
                    Email = new Email() { Value = "franciscoprestes01@gmail.com" },
                    EmpresaId = empresa.EmpresaId,
                    Empresa = empresa
                },
                new Comprador()
                {
                    Nome = "Jaqueline Britto",
                    Cpf = new CPF() { Value = "022.762.731-77" },
                    Email = new Email() { Value = "jaquebritto@gmail.com" },
                    EmpresaId = empresa.EmpresaId,
                    Empresa = empresa
                },
                new Comprador()
                {
                    Nome = "Tompson Dulley",
                    Cpf = new CPF() { Value = "022.762.731-88" },
                    Email = new Email() { Value = "tom@gmail.com" },
                    EmpresaId = empresa.EmpresaId,
                    Empresa = empresa
                },
                new Comprador()
                {
                    Nome = "Denver Espalha-Lixo",
                    Cpf = new CPF() { Value = "022.762.731-22" },
                    Email = new Email() { Value = "denver@gmail.com" },
                    EmpresaId = empresa.EmpresaId,
                    Empresa = empresa
                });

            //fornecedores
            context.Fornecedores.AddOrUpdate(
                  fornecedor => fornecedor.Nome,
                  new Domain.Entities.Fornecedor()
                  {
                      Nome = "Rafael Teixeira",
                      Cpf = new CPF() { Value = "423.848.808-37" },
                      Email = new Email() { Value = "rafaelfteixeira@hotmail.com" },

                  });

        }



    }
}

