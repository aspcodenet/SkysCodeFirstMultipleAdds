using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SkysCodeFirstMultipleAdds.Data
{
    public class DataInitializer
    {
        public void MigrateAndSeed(ApplicationDbContext context)
        {
            context.Database.Migrate();
            SeedTeams(context);
        }

        private void SeedTeams(ApplicationDbContext context)
        {
            if (!context.Teams.Any(r => r.Name == "Tre Kronor"))
            {
                context.Teams.Add(new Team { Name = "Tre Kronor" });
            }
        }
    }
}