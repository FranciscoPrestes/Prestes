namespace Prestes.Cotacao.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fornecedores : DbMigration
    {
        public override void Up()
        {
           
            DropTable("dbo.Fornecedor");
        }
        
        public override void Down()
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
            
            DropColumn("dbo.Empresa", "Endereco_Cep");
        }
    }
}
