using System.Data.Entity.Migrations;

namespace StartippWebServer.DataContext
{
    internal sealed class DatabaseConfiguration : DbMigrationsConfiguration<StartippDb>
    {
        public DatabaseConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContext";
        }

        protected override void Seed(StartippDb context)
        {
        }
    }
}