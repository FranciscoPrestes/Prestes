namespace Prestes.Cotacao.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fornecedorestable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Cpf_Value = c.String(nullable: false, maxLength: 100, unicode: false),
                        Celular = c.String(maxLength: 100, unicode: false),
                        Telefone = c.String(maxLength: 100, unicode: false),
                        Email_Value = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fornecedor");
        }
    }
}
