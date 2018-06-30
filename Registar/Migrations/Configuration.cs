namespace Registar.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Registar.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Registar.DAL.RegistarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;///za dodatne izmjene na bazi tokom kodiranja
        }

        protected override void Seed(Registar.DAL.RegistarContext context)
        {
                

        }

      /*  public DbSet<Automobil> Automobil { get; set; }
        public DbSet<Brend> Brend { get; set; }
        public DbSet<Kazna> Kazna { get; set; }
        public DbSet<LokacijaPS> LokacijaPS { get; set; }
        public DbSet<Osoba> Osoba { get; set; }
        public DbSet<Policajac> Policajac { get; set; }
        public DbSet<PolicajacPS> PolicajasPS { get; set; }
        public DbSet<PolicijskaStanica> PolicijskaStanica { get; set; }
        public DbSet<Prekrsaj> Prekrsaj { get; set; }
        public DbSet<PrekrsajKazna> PrekrsajKazna { get; set; }
        public DbSet<Spol> Spol { get; set; }
        public DbSet<Zapis> Zapis { get; set; }
        public DbSet<User> User { get; set; }
        */

        //  This method will be called after migrating to the latest version.

        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //  to avoid creating duplicate seed data.
    
        }
}

