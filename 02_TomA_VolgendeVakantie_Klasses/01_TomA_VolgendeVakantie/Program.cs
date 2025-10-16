using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_TomA_VolgendeVakantie
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
            Application.Run(new FrmStart());
        }

        // velden
        static List<Vakantie> _vakanties = new List<Vakantie>();
        
        // functies

        /// <summary>
        /// Ontvangt de naam, startdatum en einddatum van een vakantie 
        /// maakt er een object van en voegt dit object toe aan de lijst.
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvStartdatum"></param>
        /// <param name="ontvEinddatum"></param>
        public static void Toevoegen(String ontvNaam, DateTime ontvStartdatum, DateTime ontvEinddatum)
        {
            // maak een nieuw vakantie object aan
            Vakantie nieuweVakantie = new Vakantie(ontvNaam, ontvStartdatum, ontvEinddatum);

            // voeg de gegevens toe aan de lijsten
            _vakanties.Add(nieuweVakantie);

            SorteerList();
        }

        /// <summary>
        /// Stuurt de lijst met vakanties terug.
        /// </summary>
        /// <returns></returns>
        public static List<Vakantie> StuurVakantieDoor()
        {
            return _vakanties;
        }

        /// <summary>
        /// Maakt van de naam, startdatum en einddatum een object van Vakantie aan 
        /// en overschrijft hiermee het oude object in de lijst, via de index.
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvStartdatum"></param>
        /// <param name="ontvEinddatum"></param>
        public static void Aanpassen(int ontvIndex, String ontvNaam, DateTime ontvStartdatum, DateTime ontvEinddatum)
        {
            // maak een nieuw vakantie object aan
            Vakantie nieuweVakantie = new Vakantie(ontvNaam, ontvStartdatum, ontvEinddatum);

            // overschrijf het vakantie object in de lijst met dit nieuwe object
            _vakanties[ontvIndex] = nieuweVakantie;

            SorteerList();

        }

        /// <summary>
        /// Verwijdert een vakantie op basis van de meegegeven index.
        /// </summary>
        /// <param name="ontvIndex"></param>
        public static void Verwijderen(int ontvIndex)
        {
            _vakanties.RemoveAt(ontvIndex);
            
        }

        /// <summary>
        /// Berekent het aantal dagen tot de eerstvolgende vakantie en stuurt dit terug als string.
        /// </summary>
        /// <returns></returns>
        public static String AantalDagen()
        {
            String antwoord = "";

            // huidige datum
            DateTime vandaag = DateTime.Now;

            // vergelijk de datum van vandaag met de startdatums
            for(int i = 0; i < _vakanties.Count(); i++)
            {
                // vraag of de datum in de vakantie valt, doe dit via 
                // de methode in de klasse Vakantie
                sbyte uitkomst = _vakanties[i].ValtDatumInVakantie(vandaag);

                // ga na of de vakantie al bezig is
                if (uitkomst == 0)
                {
                    // Vraag de naam op van de vakantie via de property in de klasse Vakantie
                    antwoord = $"Het is momenteel vakantie: {_vakanties[i].PropVakantienaam}";
                    break;
                }

                // ga na of de vakantie nog moet beginnen
                else if (uitkomst == -1)
                {
                    // bereken het verschil tussen de vakantie en vandaag
                    int verschil = _vakanties[i].Aantaldagen(vandaag);

                    // geef het antoord terug 
                    antwoord = $"Het is nog {verschil} dagen tot {_vakanties[i].PropVakantienaam} begint.";

                    break;
                }
                else
                {
                    // Als alle vakanties overlopen zijn, geef dan een bericht terug
                    if (i == _vakanties.Count() - 1)
                    {
                        antwoord = "Er zijn geen komende vakanties meer.";
                    }
                }

                
            }

            return antwoord;
        }

        /// <summary>
        /// Sorteert de lijsten op basis van de startdatum.
        /// </summary>
        private static void SorteerList()
        {
            // tijdelijke lijst
            List<Vakantie> gesorteerdeVakanties = new List<Vakantie>();
           

            // neem elke keer de volgende datum en zet hem op de juiste plaats in de tijdelijke lijsten
            for (int i = 0; i < _vakanties.Count(); i++)
            {
                // Neem de stratdatum van de vakantie op index i
                DateTime datum = _vakanties[i].PropStartDatum;

                // loop door de tijdelijke lijst om de juiste plaats te vinden
                for (int j = 0; j <= gesorteerdeVakanties.Count(); j++)
                {
                    if(gesorteerdeVakanties.Count() == 0)
                    {
                        // als er nog geen items in de gestorteerde lijst staan, voeg het gewoon toe
                        gesorteerdeVakanties.Add(_vakanties[i]);
                        
                        break;
                    }
                    // als alles overlopen is en de datum niet kleiner was 
                    else if (j== gesorteerdeVakanties.Count())
                    {
                        // Mag de vakantie gewoon achteraan toegevoegd worden
                        gesorteerdeVakanties.Add(_vakanties[i]);
                        
                        break;
                    }
                    
                    else
                    {
                        // als er een datum van de te sorteren vakantie
                        // kleiner is dan de vakantie in de reed gesorteerde lijst
                        if (gesorteerdeVakanties[j].IsOntvDtKleiner(datum))
                        {
                            // dan moet de te sorteren vakantie worden 
                            // tussen gevoegd op de juiste plaats
                            gesorteerdeVakanties.Insert(j, _vakanties[i]);
                             
                            break;
                        }                       
                    }
                }
            }
            // Kopie de tijdelijke lijsten terug naar de originele lijsten
            _vakanties = gesorteerdeVakanties;

        }

        /// <summary>
        /// Toont alle vakanties met hun start- en einddatum, gesorteerd op startdatum.
        /// </summary>
        /// <returns></returns>
        public static String ToonAlle()
        {
            string antwoord = "";

            SorteerList();

            for (int i = 0; i < _vakanties.Count(); i++)
            {
                antwoord += $"{_vakanties[i].AlleGegevens()}";
            }

            return antwoord;

        }
    }
}
