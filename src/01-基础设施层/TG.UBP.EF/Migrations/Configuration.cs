using System.Data.Entity.Migrations;

namespace TG.UBP.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<UBP.EntityFramework.UBPDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "UBP";
        }

        protected override void Seed(UBP.EntityFramework.UBPDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
