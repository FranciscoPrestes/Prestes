namespace Prestes.Cotacao.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cepnosenderecos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresa", "Endereco_Cep", c => c.String(nullable: false, maxLength: 9, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresa", "Endereco_Cep");
        }
    }
}
