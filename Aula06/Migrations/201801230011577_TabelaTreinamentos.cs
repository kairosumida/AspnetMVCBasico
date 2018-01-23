namespace Aula06.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaTreinamentos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Treinamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeTreinamento = c.String(),
                        Inicio = c.DateTime(nullable: false),
                        Termino = c.DateTime(nullable: false),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Desconto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Local = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Treinamentoes");
        }
    }
}
