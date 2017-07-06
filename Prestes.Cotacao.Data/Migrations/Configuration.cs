using System.Data.Entity;
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

            context.Compradores.AddOrUpdate(
                p => p.Nome,
                new Comprador()
                {
                    Nome = "Francisco Prestes",
                    Cpf = new CPF() { Cpf = "022.762.731-86" },
                    Email = new Email() { Endereco = "franciscoprestes01@gmail.com" }
                },
                new Comprador()
                {
                    Nome = "Jaqueline Britto",
                    Cpf = new CPF() { Cpf = "022.762.731-77" },
                    Email = new Email() { Endereco = "jaquebritto@gmail.com" }
                },
                new Comprador()
                {
                    Nome = "Tompson Dulley",
                    Cpf = new CPF() { Cpf = "022.762.731-88" },
                    Email = new Email() { Endereco = "tom@gmail.com" }
                },
                new Comprador()
                {
                    Nome = "Denver Espalha-Lixo",
                    Cpf = new CPF() { Cpf = "022.762.731-22" },
                    Email = new Email() { Endereco = "denver@gmail.com" }
                }

                );
        }



    }
}

