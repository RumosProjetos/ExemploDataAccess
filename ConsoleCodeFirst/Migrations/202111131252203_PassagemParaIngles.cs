namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PassagemParaIngles : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Jogos", newName: "Games");
            RenameTable(name: "dbo.Plataformas", newName: "Plataforms");
            RenameColumn(table: "dbo.Games", name: "Nome", newName: "Name");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Games", name: "Name", newName: "Nome");
            RenameTable(name: "dbo.Plataforms", newName: "Plataformas");
            RenameTable(name: "dbo.Games", newName: "Jogos");
        }
    }
}
