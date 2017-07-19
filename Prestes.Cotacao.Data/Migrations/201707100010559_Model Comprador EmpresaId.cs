namespace Prestes.Cotacao.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelCompradorEmpresaId : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Comprador", new[] { "Empresa_EmpresaId" });
            RenameColumn(table: "dbo.Comprador", name: "Empresa_EmpresaId", newName: "EmpresaId");
            AlterColumn("dbo.Comprador", "EmpresaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Comprador", "EmpresaId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Comprador", new[] { "EmpresaId" });
            AlterColumn("dbo.Comprador", "EmpresaId", c => c.Int());
            RenameColumn(table: "dbo.Comprador", name: "EmpresaId", newName: "Empresa_EmpresaId");
            CreateIndex("dbo.Comprador", "Empresa_EmpresaId");
        }
    }
}
