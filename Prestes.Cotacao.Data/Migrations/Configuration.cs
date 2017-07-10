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
                    Rua = "Rua Centra;"
                }

            };


            context.Empresas.AddOrUpdate(p => p.EmpresaId, empresa);

            context.Compradores.AddOrUpdate(
                p => p.Nome,
                new Comprador()
                {
                    Nome = "Francisco Prestes",
                    Cpf = new CPF() { Value = "022.762.731-86" },
                    Email = new Email() { Value = "franciscoprestes01@gmail.com" },
                    EmpresaId = 1,
                    Empresa = empresa
                },
                new Comprador()
                {
                    Nome = "Jaqueline Britto",
                    Cpf = new CPF() { Value = "022.762.731-77" },
                    Email = new Email() { Value = "jaquebritto@gmail.com" },
                    EmpresaId = 1,
                    Empresa = empresa
                },
                new Comprador()
                {
                    Nome = "Tompson Dulley",
                    Cpf = new CPF() { Value = "022.762.731-88" },
                    Email = new Email() { Value = "tom@gmail.com" },
                    EmpresaId = 1,
                    Empresa = empresa
                },
                new Comprador()
                {
                    Nome = "Denver Espalha-Lixo",
                    Cpf = new CPF() { Value = "022.762.731-22" },
                    Email = new Email() { Value = "denver@gmail.com" },
                    EmpresaId = 1,
                    Empresa = empresa

                });
        }



    }
}

