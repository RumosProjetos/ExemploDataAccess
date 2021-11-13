namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogos",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Nome = c.String(maxLength: 255),
                        TipoJogo = c.String(maxLength: 50),
                        Posicao = c.Int(nullable: false, identity: true),
                        Plataforma_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Plataformas", t => t.Plataforma_Id)
                .Index(t => t.Plataforma_Id);
            
            CreateTable(
                "dbo.Plataformas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jogos", "Plataforma_Id", "dbo.Plataformas");
            DropIndex("dbo.Jogos", new[] { "Plataforma_Id" });
            DropTable("dbo.Plataformas");
            DropTable("dbo.Jogos");
        }
    }
}
