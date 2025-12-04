using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _04_TomA_BedrAfd_Klasses;


namespace Proj_Bedrijfsafdeling
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartMenu());
        }

        // velden 
        static List<Afdeling> _afdelingen = new List<Afdeling>();
        static List<Medewerker> _medewerkers = new List<Medewerker>();
        static MijnDB _naarDb = new MijnDB();

        // properties
        public static List<Afdeling> Afdelingen
        {
            get { return _afdelingen; }
            set { _afdelingen = value; }
        }
        public static List<Medewerker> Medewerkers
        {
            get { return _medewerkers; }
            set { _medewerkers = value; }
        }

        static public void VulLijsten()
        {
            // afdelingen vullen
            _afdelingen = _naarDb.HaalLijstAfdOp();
            // medewerkers vullen
            _medewerkers = _naarDb.HaalLijstWNOp();
        }

        public static void WnToevoegen( String ontvVn, String ontvAn, String ontvSt, int ontvIndexAfd)
        {
            Afdeling gekozenAfd = _afdelingen[ontvIndexAfd];

            Medewerker nieuweMw = new Medewerker(ontvVn, ontvAn, ontvSt, gekozenAfd);

            _naarDb.VoegWNToe( nieuweMw);

        }

        public static void AanpassenWn(int ontvIdWn, String ontvVn, String ontvAn, String ontvSt, int ontvIndexAfd)
        {
            Afdeling gekozenAfd = _afdelingen[ontvIndexAfd];

            int idMw = _medewerkers[ontvIdWn]._id;

            Medewerker nieuweMw = new Medewerker(idMw, ontvVn, ontvAn, ontvSt, gekozenAfd);

            /*
             * Medewerker nieuweMw = _medewerkers[ontvIdWn]
             * nieuweMw.Voornaam = ontvVn;
             * nieuweMw.Achternaam = ontvAn;
             * nieuweMw.Stad = ontvSt;
             * nieuweMw.Afdeling = gekozenAfd;
             * 
             * */

            _naarDb.PasWnAan(nieuweMw);
        }

    }
}
