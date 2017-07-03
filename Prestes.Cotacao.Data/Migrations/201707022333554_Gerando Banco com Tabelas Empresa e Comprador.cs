namespace Prestes.Cotacao.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GerandoBancocomTabelasEmpresaeComprador : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comprador",
                c => new
                    {
                        CampradorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Email_Endereco = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cpf_Cpf = c.String(nullable: false, maxLength: 14, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        Empresa_EmpresaId = c.Int(),
                    })
                .PrimaryKey(t => t.CampradorId)
                .ForeignKey("dbo.Empresa", t => t.Empresa_EmpresaId)
                .Index(t => t.Empresa_EmpresaId);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        EmpresaId = c.Int(nullable: false, identity: true),
                        NomeFantasia = c.String(nullable: false, maxLength: 60, unicode: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 60, unicode: false),
                        Endereco_Rua = c.String(nullable: false, maxLength: 60, unicode: false),
                        Endereco_Numero = c.String(nullable: false, maxLength: 12, unicode: false),
                        Endereco_Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Endereco_Cidade = c.String(nullable: false, maxLength: 40, unicode: false),
                        Endereco_Estado_Nome = c.String(nullable: false, maxLength: 30, unicode: false),
                        Endereco_Estado_Abreviacao = c.String(nullable: false, maxLength: 2, unicode: false),
                        Cnpj_Cnpj = c.String(maxLength: 100, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmpresaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comprador", "Empresa_EmpresaId", "dbo.Empresa");
            DropIndex("dbo.Comprador", new[] { "Empresa_EmpresaId" });
            DropTable("dbo.Empresa");
            DropTable("dbo.Comprador");
        }
    }
}
