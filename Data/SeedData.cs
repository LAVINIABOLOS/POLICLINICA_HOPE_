using System.Linq;
using POLICLINICA_HOPE_.Models;

namespace POLICLINICA_HOPE_.Data
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.Medici.Any())
            {
                context.Medici.AddRange(
                    new Medic { Nume = "Popescu", Prenume = "Ion" },
                    new Medic { Nume = "Ionescu", Prenume = "Maria" },
                    new Medic { Nume = "Georgescu", Prenume = "Ana" },
                    new Medic { Nume = "Petrescu", Prenume = "Cristian" },
                    new Medic { Nume = "Dumitrescu", Prenume = "Andrei" }
                );
            }

            if (!context.Departamente.Any())
            {
                context.Departamente.AddRange(
                    new Departament { Denumire = "Cardiologie" },
                    new Departament { Denumire = "Dermatologie" },
                    new Departament { Denumire = "Pediatrie" },
                    new Departament { Denumire = "Chirurgie" },
                    new Departament { Denumire = "Radiologie" }
                );
            }

            context.SaveChanges();
        }
    }
}
