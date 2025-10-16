using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TomA_Minigolf
{
    internal class Speler
    {
        // Velden
        int _id = 0;
        string _voornaam = "" ;
        string _naam = "";
        int _totaalSlagen = 0;

        // public int _id { get; }
        // public string _naam { get; set; }

        // eigenschappen (properties)

        /// <summary>
        /// Geeft de waarde van _id terug, maar laat deze niet toe om aangepast te worden.
        /// </summary>
        public int PropId
        {
            get { return _id; }
            
        }
        /// <summary>
        /// Geeft de waarde van _voornaam terug, en laat deze toe om aangepast te worden.
        /// </summary>
        public string PropVoornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        /// <summary>
        /// Geeft de waarde van _naam terug, en laat deze toe om aangepast te worden.
        /// </summary>
        public string PropNaam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        /// <summary>
        /// Geeft de waarde van _totaalSlagen terug, en laat deze toe om aangepast te worden.
        /// </summary>
        public int PropTotaalSlagen
        {
            get { return _totaalSlagen; }
            set { _totaalSlagen = value; }
        }
        // methoden
        /// <summary>
        /// Geeft de volledige naam van de speler terug.
        /// </summary>
        /// <returns></returns>
        public string VolledigeNaam() 
        { 
               return _voornaam + " " + _naam;
        }

        /// <summary>
        /// Geeft de volledige naam van de speler terug, gevolgd door het totaal aantal slagen.
        /// </summary>
        /// <returns></returns>
        public string NaamEnTotaal()
        {
            return $"{VolledigeNaam()} : {_totaalSlagen} slagen";

        }

        /// <summary>
        /// Past het totaal aantal slagen aan door een opgegeven aantal extra slagen toe te voegen.
        /// </summary>
        /// <param name="extraSlagen">het aantal extra slagen dat bij het totaal opgeteld moet worden</param>
        public void TotaalAanpassen(int extraSlagen )
        {
            _totaalSlagen += extraSlagen;
        }

        // constructoren
        public Speler() { }

        public Speler(string voornaam, string naam)
        {
            _voornaam = voornaam;
            _naam = naam;
            
        }


        public Speler(int id, string voornaam, string naam, int ontvSlagen)
        {
            _id = id;
            _voornaam = voornaam;
            _naam = naam;
            _totaalSlagen = ontvSlagen;
        }


    }
}
