namespace ConsoleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleCodeFirst.Model.PlataformaDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ConsoleCodeFirst.Model.PlataformaDBContext";
        }

        protected override void Seed(ConsoleCodeFirst.Model.PlataformaDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //context.Plataformas.Add(new Model.Plataforma { Nome = "Playstation" });
            //context.Plataformas.Add(new Model.Plataforma { Nome = "Xbox" });

        }
    }
}
