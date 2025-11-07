using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _03_TomA_Minigolf
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SpelFormulier());
        }

        // Velden
        static List<Speler> _spelers = new List<Speler>();
        static PersistentNaarDB _db = new PersistentNaarDB();

        // Functies 
        /// <summary>
        /// Reset de database en start een nieuw spel.
        /// </summary>
        static public void NieuwSpel()
        {
            _db.DbReset();
            VulLijst();
        }

        /// <summary>
        /// Haalt de gegevens uit de database en vult de lijst met spelers.
        /// </summary>
        static public void VulLijst()
        {
            _spelers = _db.GetSpelers();
        }

        /// <summary>
        /// Voegt een nieuwe speler toe aan de database.
        /// </summary>
        /// <param name="ontvVoorn">De voornaam van de speler</param>
        /// <param name="ontvAchtern">De familienaam van de speler</param>
        static public void ToevoegenSpeler(String ontvVoorn, String ontvAchtern)
        {
            Speler nieuweSpeler = new Speler(ontvVoorn, ontvAchtern);
            _db.DbToevoegenSpeler(nieuweSpeler);

            VulLijst();
        }
        /// <summary>
        ///  stuurt de lijst van de spelers door naar het formulier
        /// </summary>
        /// <returns></returns>
        static public List<Speler> StuurSpelersDoor()
        {
            VulLijst();
            return _spelers;
        }

        /// <summary>
        /// past de gegevens van de speler aan in de database
        /// </summary>
        /// <param name="ontvIndex">de volgorde van de speler in de lijst</param>
        /// <param name="ontvVoorn">De voornaam van de speler</param>
        /// <param name="ontvAchtern">De familienaam van de speler</param>
        static public void AanpassenSpeler(int ontvIndex, String ontvVoorn, String ontvAchtern)
        {
            // object van speler maken 
            Speler nieuweSpeler = _spelers[ontvIndex];

            // gegeven aanpassen
            nieuweSpeler.PropVoornaam = ontvVoorn;
            nieuweSpeler.PropNaam = ontvAchtern;

            // aanpassing doorvoeren in database
            _db.DbAanpassenSpeler(nieuweSpeler);

            // lijst opnieuw vullen
            VulLijst();
        }

        /// <summary>
        /// verwijdert een speler uit de database
        /// </summary>
        /// <param name="ontvIndex">de volgorde van de speler in de lijst</param>
        static public void Verwijderen(int ontvIndex)
        {
            // object van speler maken 
            Speler nieuweSpeler = _spelers[ontvIndex];

            // doorsturen naar de persistent
           _db.DbVerwijderSpeler(nieuweSpeler);

            // lijst opnieuw vullen
            VulLijst();
        }

        /// <summary>
        /// past de score van de speler aan door het aantal slagen toe te voegen
        /// </summary>
        /// <param name="aantalSlagen">Het aantal slagen dat wordt toegvoegd. Kan zowel positief als negatief zijn</param>
        static public void PasScoreAan(int ontvIndex, int aantalSlagen)
        {
            _spelers[ontvIndex].TotaalAanpassen(aantalSlagen);
            _db.DbAanpassenSpeler(_spelers[ontvIndex]);

        }

        /// <summary>
        /// Stuurt alle gegevens van alle spelers door als een string
        /// </summary>
        /// <returns></returns>
        static public String ToonGegevens()
        {
            // Laat de lijst vullen 
            VulLijst();

            string antwoord = "";

            foreach (Speler s in _spelers)
            {
                antwoord +=  s.NaamEnTotaal() + Environment.NewLine;
            }

            return antwoord;
        }

    }
}
