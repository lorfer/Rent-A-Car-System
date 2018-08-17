namespace GUI_MODERNISTA.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GUI_MODERNISTA.Models.DataB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GUI_MODERNISTA.Models.DataB";
        }

        protected override void Seed(GUI_MODERNISTA.Models.DataB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
