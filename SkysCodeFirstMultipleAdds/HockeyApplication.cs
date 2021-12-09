using Microsoft.EntityFrameworkCore;
using SkysCodeFirstMultipleAdds.Data;

namespace SkysCodeFirstMultipleAdds
{
    public class HockeyApplication
    {
        private readonly string _connectionString;

        public HockeyApplication(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Run()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            options.UseSqlServer(_connectionString);

            using (var context = new ApplicationDbContext(options.Options))
            {

            }


        }
    }
}