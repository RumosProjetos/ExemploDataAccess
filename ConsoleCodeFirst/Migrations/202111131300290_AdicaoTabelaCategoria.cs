namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoTabelaCategoria : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Games", name: "Posicao", newName: "Position");
            RenameColumn(table: "dbo.Plataforms", name: "Nome", newName: "Name");
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Games", "Categoria_Id", c => c.Int());
            CreateIndex("dbo.Games", "Categoria_Id");
            AddForeignKey("dbo.Games", "Categoria_Id", "dbo.Category", "Id");
            DropColumn("dbo.Games", "TipoJogo");
        }

        
        public override void Down()
        {
            AddColumn("dbo.Games", "TipoJogo", c => c.String(maxLength: 50));
            DropForeignKey("dbo.Games", "Categoria_Id", "dbo.Category");
            DropIndex("dbo.Games", new[] { "Categoria_Id" });
            DropColumn("dbo.Games", "Categoria_Id");
            DropTable("dbo.Category");
            RenameColumn(table: "dbo.Plataforms", name: "Name", newName: "Nome");
            RenameColumn(table: "dbo.Games", name: "Position", newName: "Posicao");
        }
    }
}
