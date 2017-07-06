namespace Prestes.Cotacao.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjustaCNPJ : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empresa", "Cnpj_Cnpj", c => c.String(nullable: false, maxLength: 18, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empresa", "Cnpj_Cnpj", c => c.String(maxLength: 100, unicode: false));
        }
    }
}
