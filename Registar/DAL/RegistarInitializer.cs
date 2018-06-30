using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Registar.Models;
namespace Registar.DAL

{
    public class RegistarInitializer : CreateDatabaseIfNotExists<RegistarContext>
    {
       
        protected  override void Seed(RegistarContext context)
        {
                    
            // Look for any osobas xd.
            if (context.Spol.Any())
            {
                return;   // DB has been seeded
            }
            var osobe = new Osoba[] {
            new Osoba {Ime="Irfan", Prezime="Nefic", JMBG = 1203984123321, VozackaDozvola = "A12311TD"},
            //new Osoba {Ime = "Adi", Prezime = "Novica", JMBG = 2709981124321, VozackaDozvola = "B12C11TD"}
            };

            foreach (Osoba s in osobe)
            {
                context.Osoba.Add(s);
            }
            context.SaveChanges();
            

        }
    
    }
}