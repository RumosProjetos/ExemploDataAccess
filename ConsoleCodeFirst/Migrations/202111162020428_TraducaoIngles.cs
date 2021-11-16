namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TraducaoIngles : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ConteudoBaixadoes", newName: "DownloadContents");
            RenameTable(name: "dbo.ConsoleGame", newName: "ConsoleGames");
            RenameTable(name: "dbo.Games_NewName", newName: "Games");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Games", newName: "Games_NewName");
            RenameTable(name: "dbo.ConsoleGames", newName: "ConsoleGame");
            RenameTable(name: "dbo.DownloadContents", newName: "ConteudoBaixadoes");
        }
    }
}
