using System;
using System.Linq;
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
                //Konto 1
                // Konto 2
                // 100 kr från konto 1 -> konto 2
                // update account set saldo=saldo-100 where acc='klonto1'
                // STRÖMMEN GÅR
                // update account set saldo=saldo+100 where acc='klonto2'

                //Update
                var teamet = context.Teams.FirstOrDefault(r => r.Name == "Russia");
                if (teamet != null)
                {
                    teamet.Name = "3412132";
                    //teamet.JKHLIHJKJKLJKL = "";

                    context.SaveChanges();
                }


                Console.WriteLine("Create player....ange namn:");
                var namn = Console.ReadLine();
                Console.WriteLine("ange age:");
                var age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ange namn på team:");
                var teamName = Console.ReadLine();

                var player = new Player();
                player.Name = namn;
                player.Age = age;

                //tre kror <--
                //tre kronor

                // Logiken - hämta team-objekt från databas med det namnet
                var team = context.Teams.FirstOrDefault(t => t.Name == teamName);
                if (team == null)
                {
                    //FInns inte - vill du skapa upp ett sånt ölag
                    team = new Team { Name = teamName  };
                    context.Teams.Add(team);
                }
                team.Players.Add(player); 

                context.SaveChanges();
            }


        }
    }
}