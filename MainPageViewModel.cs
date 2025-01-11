using System.Collections.ObjectModel;
using POLICLINICA_HOPE_.Models;

namespace POLICLINICA_HOPE_.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Medic> Medici { get; set; }
        public ObservableCollection<Procedura> Proceduri { get; set; }
        public ObservableCollection<Departament> Departamente { get; set; }

        public MainPageViewModel()
        {
            // Exemplu de date fictive
            Medici = new ObservableCollection<Medic>
            {
                new Medic { Nume = "Popescu", Prenume = "Ion" },
                new Medic { Nume = "Ionescu", Prenume = "Maria" }
            };

            Proceduri = new ObservableCollection<Procedura>
            {
                new Procedura { Denumire = "Consultatie", Pret = 100 },
                new Procedura { Denumire = "Interventie", Pret = 500 }
            };

            Departamente = new ObservableCollection<Departament>
            {
                new Departament { Denumire = "Cardiologie" },
                new Departament { Denumire = "Dermatologie" }
            };
        }
    }
}
