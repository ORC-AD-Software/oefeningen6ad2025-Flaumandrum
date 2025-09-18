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
        static List<String> _naamVakantie = new List<String>();
        static List<DateTime> _startdatum = new List<DateTime>();
        static List<DateTime> _einddatum = new List<DateTime>();



        // functies

        /// <summary>
        /// Ontvangt de naam, startdatum en einddatum van een vakantie en voegt deze toe aan de lijsten.
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvStartdatum"></param>
        /// <param name="ontvEinddatum"></param>
        public static void Toevoegen(String ontvNaam, DateTime ontvStartdatum, DateTime ontvEinddatum)
        {
            _naamVakantie.Add(ontvNaam);
            _startdatum.Add(ontvStartdatum);
            _einddatum.Add(ontvEinddatum);

            SorteerList();
        }

        /// <summary>
        /// Stuurt de lijst met vakantienamen terug.
        /// </summary>
        /// <returns></returns>
        public static List<String> StuurVakantieDoor()
        {
            return _naamVakantie;
        }

        /// <summary>
        /// Past de naam, startdatum en einddatum van een vakantie aan op basis van de meegegeven index.
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvStartdatum"></param>
        /// <param name="ontvEinddatum"></param>
        public static void Aanpassen(int ontvIndex, String ontvNaam, DateTime ontvStartdatum, DateTime ontvEinddatum)
        {
            _naamVakantie[ontvIndex] = ontvNaam;
            _startdatum[ontvIndex] = ontvStartdatum;
            _einddatum[ontvIndex] = ontvEinddatum;
            SorteerList();

        }

        /// <summary>
        /// Verwijdert een vakantie op basis van de meegegeven index.
        /// </summary>
        /// <param name="ontvIndex"></param>
        public static void Verwijderen(int ontvIndex)
        {
            _naamVakantie.RemoveAt(ontvIndex);
            _startdatum.RemoveAt(ontvIndex);
            _einddatum.RemoveAt(ontvIndex);
        }

        /// <summary>
        /// Berekent het aantal dagen tot de eerstvolgende vakantie en stuurt dit terug als string.
        /// </summary>
        /// <returns></returns>
        public static String AantalDagen()
        {
            String antwoord = "";

            


            return antwoord;
        }

        /// <summary>
        /// Sorteert de lijsten op basis van de startdatum.
        /// </summary>
        private static void SorteerList()
        {
            // tijdelijke lijsten
            List<String> gesorteerdeNamen = new List<String>();
            List<DateTime> gesorteerdeStartDatums = new List<DateTime>();
            List<DateTime> gesorteerdeEindDatums = new List<DateTime>();

            // neem elke keer de volgende datum en zet hem op de juiste plaats in de tijdelijke lijsten
            for (int i = 0; i < _startdatum.Count(); i++)
            {
                DateTime datum = _startdatum[i];
                
                for(int j = 0; j <= gesorteerdeStartDatums.Count(); j++)
                {
                    if(gesorteerdeStartDatums.Count() == 0)
                    {
                        // als er nog geen items in de gestorteerde lijst staan, voeg het gewoon toe
                        gesorteerdeNamen.Add(_naamVakantie[i]);
                        gesorteerdeStartDatums.Add(_startdatum[i]);
                        gesorteerdeEindDatums.Add(_einddatum[i]);
                        break;
                    }
                    // als alles overlopen is en de datum niet kleiner was 
                    else if (j== gesorteerdeStartDatums.Count())
                    {
                        gesorteerdeNamen.Add(_naamVakantie[i]);
                        gesorteerdeStartDatums.Add(_startdatum[i]);
                        gesorteerdeEindDatums.Add(_einddatum[i]);
                        break;
                    }
                    // als er een datum wordt gevonden die groter is
                    else
                    {
                       if(datum < gesorteerdeStartDatums[j])
                        {
                            // voeg de nieuwe datum op de juiste plaats in
                            gesorteerdeNamen.Insert(j, _naamVakantie[i]);
                            gesorteerdeStartDatums.Insert(j, _startdatum[i]);
                            gesorteerdeEindDatums.Insert(j, _einddatum[i]); 
                            break;
                        }
                       
                    }
                }

                

            }
            // Kopie de tijdelijke lijsten terug naar de originele lijsten
            _naamVakantie = gesorteerdeNamen;
            _startdatum = gesorteerdeStartDatums;
            _einddatum = gesorteerdeEindDatums;

        }

        /// <summary>
        /// Toont alle vakanties met hun start- en einddatum, gesorteerd op startdatum.
        /// </summary>
        /// <returns></returns>
        public static String ToonAlle()
        {
            string antwoord = "";

            SorteerList();

            for (int i = 0; i < _naamVakantie.Count(); i++)
            {
                antwoord += $"{_naamVakantie[i]}: {_startdatum[i]:dd-MM-yyyy} tot {_einddatum[i]:dd-MM-yyyy} \n";
            }

            return antwoord;

        }
    }
}
