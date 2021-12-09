using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SkysCodeFirstMultipleAdds.Data;

namespace SkysCodeFirstMultipleAdds
{
    // CODEALONG _ 2021-12-09   = Coding day - INGEN POWERPOINT !
    
    // Note to Stefan: ej i Main idag ;)

    //1. Flera adds i "samma" SaveChanges
    //          Team har namn + många spelare.
    //          Vi ska skapa en Player. id, namn, age (ska mata in namn på teamet)
    //          OM teamet finns så ska playern bara stoppas in i det teamet
    //          annars SKAPA team - stoppa in player i DET teamet
    
    //2.    Uppdateringar. Inte context.<entity>.add utan bara  First och sen sätt properties och sen
    //                  savechanges
    //
    //3, Resten av tiden = HANDLEDNING - dvs vi flyttar lite till nästa vecka! + INLÄMNING #3
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            string s =
                config.GetConnectionString("DefaultConnection");
            options.UseSqlServer(s);

            using (var context = new ApplicationDbContext(options.Options))
            {
                var dataInitializer = new DataInitializer();
                dataInitializer.MigrateAndSeed(context);
            }



            var app = new HockeyApplication(s);
            app.Run();
            //Console.WriteLine("Hello World!");
        }
    }
}

