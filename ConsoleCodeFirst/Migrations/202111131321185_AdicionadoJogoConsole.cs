namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoJogoConsole : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConsoleGame",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MidiaFisica = c.Boolean(nullable: false),
                        CaminhoFoto = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConsoleGame", "Id", "dbo.Games");
            DropIndex("dbo.ConsoleGame", new[] { "Id" });
            DropTable("dbo.ConsoleGame");
        }
    }
}
