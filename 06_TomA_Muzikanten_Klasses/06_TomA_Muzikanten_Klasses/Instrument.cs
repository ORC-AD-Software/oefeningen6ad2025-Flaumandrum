using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TomA_Muzikanten_Klasses
{
    public class Instrument
    {
        // Velden + Eigenschappen
        public int _id { get; }
        public string _naam { get; set;  } = null;
        public string _groep { get; set; } = null;

        public List<Leerling> _leerlingen { get; set; } = new List<Leerling>();

        // Methoden
        public String AlleGegevens()
        {
            return $"Naam: {_naam}, Groep: {_groep}";
        }
        public String LijstLeerlingen()
        {
            String antwoord = "";   

            foreach (Leerling l in _leerlingen)
            {
                antwoord += l.VolledigeNaam() + "\n";
            }

            return antwoord;
        }

        // Constructor
        public Instrument()
        {
        }

        public Instrument(string naam, string groep)
        {
            _naam = naam;
            _groep = groep;
        }
        public Instrument(int id, string naam, string groep)
        {
            _id = id;
            _naam = naam;
            _groep = groep;
        }
        public Instrument(string naam, string groep, List<Leerling> leerlingen)
        {
            _naam = naam;
            _groep = groep;
            _leerlingen = leerlingen;
        }
        public Instrument(int id, string naam, string groep, List<Leerling> leerlingen)
        {
            _id = id;
            _naam = naam;
            _groep = groep;
            _leerlingen = leerlingen;
        }


    }
}
