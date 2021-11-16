namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteradaTabelaGAmesParaNewName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Games", newName: "Games_NewName");
            AlterColumn("dbo.Games_NewName", "ReleaseDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games_NewName", "ReleaseDate", c => c.DateTime(nullable: false));
            RenameTable(name: "dbo.Games_NewName", newName: "Games");
        }
    }
}
