namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteradaTabelaJogos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConteudoBaixadoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        JogoId = c.Guid(nullable: false),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Games", "ReleaseDate", c => c.DateTime(nullable: true, defaultValueSql:"GETDATE()"));
            AddColumn("dbo.Games", "Finalizado", c => c.Boolean(nullable: true, defaultValue:false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Finalizado");
            DropColumn("dbo.Games", "ReleaseDate");
            DropTable("dbo.ConteudoBaixadoes");
        }
    }
}
