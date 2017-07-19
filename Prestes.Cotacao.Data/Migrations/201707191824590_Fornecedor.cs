namespace Prestes.Cotacao.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FornecedorMigration : DbMigration
    {
        public override void Up()
        {
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empresa", "Endereco_Cep", c => c.String(nullable: false, maxLength: 9, unicode: false));
            DropTable("dbo.Fornecedor");
        }
    }
}
