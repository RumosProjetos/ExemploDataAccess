namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoHistorico : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        JogadorId = c.Guid(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.JogadorId);
            
            CreateTable(
                "dbo.Progress",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Percentual = c.Single(nullable: false, defaultValue: 0),
                        JogadoEm = c.DateTime(nullable: false, defaultValueSql:"GETDATE()"),
                        Jogador_JogadorId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Jogador_JogadorId)
                .Index(t => t.Jogador_JogadorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Progress", "Jogador_JogadorId", "dbo.Players");
            DropIndex("dbo.Progress", new[] { "Jogador_JogadorId" });
            DropTable("dbo.Progress");
            DropTable("dbo.Players");
        }
    }
}
