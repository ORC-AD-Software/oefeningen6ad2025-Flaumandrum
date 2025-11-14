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
        int _id { get;  }
        string _afdelingsnaam { get; set; }
        string _afdelingshoofd { get; set; }
        List<Medewerker> _medewerkers { get; set; }

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
    }
}
