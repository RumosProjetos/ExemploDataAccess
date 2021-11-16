namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADicionadaPropriedadeNaoMapeada : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "DataNascimento", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "DataNascimento");
        }
    }
}
