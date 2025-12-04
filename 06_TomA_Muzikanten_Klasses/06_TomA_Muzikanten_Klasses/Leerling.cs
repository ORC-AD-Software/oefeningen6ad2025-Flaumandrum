using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TomA_Muzikanten_Klasses
{
    public class Leerling
    {
        // velden + eigenschappen
        public int _id { get; }
        public string _voornaam { get; set; } = null;
        public string _achternaam { get; set;  } = null;
        public List<Instrument> _instrumenten { get; set; } = new List<Instrument>();


        // methoden
        /// <summary>
        /// stuurt de volledige naam van de leerling terug
        /// </summary>
        /// <returns></returns>
        public String VolledigeNaam()
        {
            return $"{_voornaam} {_achternaam}";
        }
        public String LijstInstrumenten()
        {
            string antwoord = "";
           
            foreach (Instrument i in _instrumenten)
            {
                antwoord += i._naam + "\n";
            }
            
            return antwoord;
        }

        // constructor
        public Leerling()
        {
        }
        public Leerling(string voornaam, string achternaam)
        {
            _voornaam = voornaam;
            _achternaam = achternaam;
        }

        public Leerling(string voornaam, string achternaam, List<Instrument> instrumenten)
        {
            _voornaam = voornaam;
            _achternaam = achternaam;
            _instrumenten = instrumenten;
        }
        public Leerling(int id, string voornaam, string achternaam)
        {
            _id = id;
            _voornaam = voornaam;
            _achternaam = achternaam;
        }

        public Leerling(int id, string voornaam, string achternaam, List<Instrument> instrumenten)
        {
            _id = id;
            _voornaam = voornaam;
            _achternaam = achternaam;
            _instrumenten = instrumenten;
        }
    }
}
