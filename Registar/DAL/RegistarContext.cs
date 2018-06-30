using Registar.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Registar.DAL
{
    public class RegistarContext : DbContext
    {

        public RegistarContext() : base("RegistarMVC")
        {
            
        }
        

        public DbSet<Automobil> Automobil { get; set; }
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
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            

        }
    }
}