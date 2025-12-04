using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_TomA_BedrAfd_Klasses
{
    public class Afdeling
    {
        // Velden + properties
        public int _id { get;  }
        public string _afdelingsnaam { get; set; }
        public string _afdelingshoofd { get; set; }
        public List<Medewerker> _medewerkers { get; set; }

        /*public string PropAfdelingsnaam
        {
            get { return _afdelingsnaam; }
            set { _afdelingsnaam = value; }
        }
        */

        // Methoden
        /// <summary>
        /// Geeft de naam van de afdeling en het hoofd van de afdeling terug.
        /// </summary>
        /// <returns></returns>
        public string GetGegevensAfdeling() 
        {
            return $"{_afdelingsnaam} - Hoofd: {_afdelingshoofd}";
        }
        /// <summary>
        /// Geef een lijst (als tekst) van medewerkers in de afdeling terug.
        /// </summary>
        /// <returns></returns>
        public string GetMedewerkers()
        {
            string antwoord = "";
            foreach(Medewerker m in _medewerkers)
            {
               antwoord += m.GetVolledigeNaam() + "\n";
            }

            return antwoord;
        }

        // Constructors
        public Afdeling() { }

        public Afdeling(string afdNaam, string afdHoofd)
        {
            _afdelingsnaam = afdNaam;
            _afdelingshoofd = afdHoofd;
        }

        public Afdeling(int id, string afdNaam, string afdHoofd)
        {
            _id = id;
            _afdelingsnaam = afdNaam;
            _afdelingshoofd = afdHoofd;
        }

        public Afdeling(string afdNaam, string afdHoofd, List<Medewerker> medewAfd)
        {
            _afdelingsnaam = afdNaam;
            _afdelingshoofd = afdHoofd;
            _medewerkers = medewAfd;
        }

        public Afdeling(int id, string afdNaam, string afdHoofd, List<Medewerker> medewAfd)
        {
            _id = id;
            _afdelingsnaam = afdNaam;
            _afdelingshoofd = afdHoofd;
            _medewerkers = medewAfd;
        }
    }
}
