using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_TomA_BedrAfd_Klasses
{
    public class Medewerker
    {
        // Velden + properties
        int _id { get; }
        string _voornaam { get; set; }
        string _achternaam { get; set; }
        string _statuut { get; set; }
        Afdeling _afdeling { get; set; }

        // Methoden
        /// <summary>
        /// geeft de afdeling en hoofd van de afdeling terug
        /// </summary>
        /// <returns></returns>
        public string GetAfdelingEnHoofd() 
        { 
            return _afdeling.GetGegevensAfdeling();
        }
        /// <summary>
        /// geeft de volledige naam van de medewerker terug
        /// </summary>
        /// <returns></returns>
        public string GetVolledigeNaam()
        {
            return $"{_voornaam} {_achternaam}";
        }

        /// <summary>
        ///  geeft de naam en statuut van de medewerker terug
        /// </summary>
        /// <returns></returns>
        public string GetNaamStatuut()
        {
            return $"{GetVolledigeNaam()} - {_statuut}";
        }

        /// <summary>
        ///  geeft alle gegevens van de medewerker terug
        /// </summary>
        /// <returns></returns>
        public string GetAlleGegevensMedewerker()
        {
            String antwoord = "";
            
            antwoord += $"{GetNaamStatuut()}\n   Afdeling {GetAfdelingEnHoofd()}";

            return antwoord;
        }

        // Constructors
        public Medewerker() { }

        public Medewerker(string voornaam, string achternaam)
        {
            _voornaam = voornaam;
            _achternaam = achternaam;

        }

        public Medewerker(string voornaam, string achternaam, string statuut)
        {

            _voornaam = voornaam;
            _achternaam = achternaam;
            _statuut = statuut;
            
        }

        public Medewerker( string voornaam, string achternaam, string statuut, Afdeling afdeling)
        {
           
            _voornaam = voornaam;
            _achternaam = achternaam;
            _statuut = statuut;
            _afdeling = afdeling;
        }

        public Medewerker (int id, string voornaam, string achternaam, string statuut, Afdeling afdeling)
        {
            _id = id;
            _voornaam = voornaam;
            _achternaam = achternaam;
            _statuut = statuut;
            _afdeling = afdeling;
        }
    }
}
