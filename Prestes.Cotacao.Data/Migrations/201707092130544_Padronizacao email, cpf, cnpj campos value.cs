namespace Prestes.Cotacao.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Padronizacaoemailcpfcnpjcamposvalue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comprador", "Email_Value", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AddColumn("dbo.Comprador", "Cpf_Value", c => c.String(nullable: false, maxLength: 14, unicode: false));
            AddColumn("dbo.Empresa", "Cnpj_Value", c => c.String(nullable: false, maxLength: 18, unicode: false));
            DropColumn("dbo.Comprador", "Email_Endereco");
            DropColumn("dbo.Comprador", "Cpf_Cpf");
            DropColumn("dbo.Empresa", "Cnpj_Cnpj");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empresa", "Cnpj_Cnpj", c => c.String(nullable: false, maxLength: 18, unicode: false));
            AddColumn("dbo.Comprador", "Cpf_Cpf", c => c.String(nullable: false, maxLength: 14, unicode: false));
            AddColumn("dbo.Comprador", "Email_Endereco", c => c.String(nullable: false, maxLength: 100, unicode: false));
            DropColumn("dbo.Empresa", "Cnpj_Value");
            DropColumn("dbo.Comprador", "Cpf_Value");
            DropColumn("dbo.Comprador", "Email_Value");
        }
    }
}
