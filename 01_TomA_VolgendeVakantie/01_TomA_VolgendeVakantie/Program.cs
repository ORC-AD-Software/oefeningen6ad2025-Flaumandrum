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

        }

        /// <summary>
        /// Verwijdert een vakantie op basis van de meegegeven index.
        /// </summary>
        /// <param name="ontvIndex"></param>
        public static void Verwijderen(int ontvIndex)
        {

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

    }
}
