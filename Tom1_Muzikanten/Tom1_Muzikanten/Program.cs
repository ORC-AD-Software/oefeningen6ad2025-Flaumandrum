using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06_TomA_Muzikanten_Klasses;


namespace Tom1_Muzikanten
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
            Application.Run(new Form1());
        }

        // De code voor het menu
        // https://www.youtube.com/watch?v=Ns0pBlbBZmE


        //Velden
        static List<Instrument> _lijstInstrumenten = new List<Instrument>();
        static List<Leerling> _lijstLeerlingen = new List<Leerling>();
        static MijnDb _naarDB = new MijnDb();


        
        // Functies 
        /// <summary>
        ///  Vult de lijsten met gegevens uit de databank
        /// </summary>
        static public void VulLijsten()
        {
            _lijstInstrumenten = _naarDB.LijstInstrumenten();
            _lijstLeerlingen = _naarDB.LijstLeerlingen();

        }


        /// <summary>
        /// Stuurt een lijst met alle namen van de instrumneten 
        /// </summary>
        /// <returns></returns>
        static public List<String> GetNaamInstrumenten()
        {
            VulLijsten();
            List<String> tempLijst = new List<String>();

            foreach (Instrument inst in _lijstInstrumenten)
            {
                tempLijst.Add(inst._naam);
            }

            return tempLijst;
        }

        /// <summary>
        /// Stuur de tekst waarin alle instrumenten en hun groep opgelijst staan
        /// </summary>
        /// <returns></returns>
        static public String GetAlleGegInstrumenten()
        {
            VulLijsten();
            String tempStr = "";

            foreach (Instrument inst in _lijstInstrumenten)
            {
                tempStr += inst.AlleGegevens() + Environment.NewLine;
            }

            return tempStr;
        }

        /// <summary>
        ///  Stuurt een lijst terug met de volledige naam van alle leerlingen 
        /// </summary>
        /// <returns></returns>
        static public List<String> GetNaamLln ()
        {
            VulLijsten();
            List<String> tempLijst = new List<String>();

            foreach (Leerling lln in _lijstLeerlingen)
            {
                tempLijst.Add(lln.VolledigeNaam());
            }

            return tempLijst;
        }

        /// <summary>
        /// Stuurt een lijst terug met de volledige naam van alle leerlingen 
        /// </summary>
        /// <returns></returns>
        static public String GetAlleGegLln()
        {
            VulLijsten();
            string tempStr = "";

            foreach (Leerling lln in _lijstLeerlingen)
            {
                tempStr += lln.VolledigeNaam() + Environment.NewLine;
            }

            return tempStr;
        }

        /// <summary>
        /// Geef de volledige naam weer van alle leerlingen die een bepaald instrument bespelen.
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public String LlnVanInstrument(int ontvIndex)
        {
            VulLijsten();
            String tempStr = "";

            foreach (Leerling l in _lijstInstrumenten[ontvIndex]._leerlingen)
            { 
                tempStr += l.VolledigeNaam() + Environment.NewLine;

            }

            return tempStr;
        }

        /// <summary>
        /// Geeft het juiste object door van de leerling op deze index in de lijst
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public Leerling GetLeerling(int ontvIndex)
        {
            VulLijsten();
            return _lijstLeerlingen[ontvIndex];
        }

        /// <summary>
        /// Geeft de instrumenten weer die een leerling kan spelen 
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public String InstrVanLln(int ontvIndex)
        {
            VulLijsten();
            String tempStr = "";

            foreach (Instrument i in _lijstLeerlingen[ontvIndex]._instrumenten)
            {
                tempStr += i._naam + Environment.NewLine;
            }

            return tempStr;
        }

        /// <summary>
        /// Ontvangt de gegevens van een instrument, 
        /// maakt er een object van en stuurt dit naar de database
        /// </summary>
        /// <param name="nm"></param>
        /// <param name="grp"></param>
        /// <param name="ontvIndexLln"></param>
        static public void VoegInstToe(string nm, String grp, List<int> ontvIndexLln)
        {
            List<Leerling> tempLlnLijst = new List<Leerling>();

            foreach (int idx in ontvIndexLln)
            {
                tempLlnLijst.Add(_lijstLeerlingen[idx]);
            }
            Instrument nieuwInst = new Instrument(nm, grp, tempLlnLijst);

            _naarDB.ToevDbInstr(nieuwInst);
            VulLijsten();
        }

        /// <summary>
        ///  Geeft het juiste object door van de instrumenten op deze index in de lijst
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public Instrument GetInstrument(int ontvIndex)
        {
            VulLijsten();
            return _lijstInstrumenten[ontvIndex];
        }


        /// <summary>
        /// Ontvangt de gegevens van de GUI
        /// maakt een nieuw object van instrument met deze gegevens 
        /// en stuurt deze door naar de database
        /// </summary>
        /// <param name="ontvIndexInst"></param>
        /// <param name="nm"></param>
        /// <param name="grp"></param>
        /// <param name="ontvIndexLln"></param>
        static public void InstAanpassen(int ontvIndexInst, string nm, String grp, List<int> ontvIndexLln)
        {
            List<Leerling> tempLlnLijst = new List<Leerling>();

            foreach (int idx in ontvIndexLln)
            {
                tempLlnLijst.Add(_lijstLeerlingen[idx]);
            }

            Instrument nieuwInst = new Instrument(_lijstInstrumenten[ontvIndexInst]._id,nm, grp, tempLlnLijst);
            _naarDB.AanpDbInst(nieuwInst);
            VulLijsten();
        }


        /// <summary>
        /// Neemy het juiste object uit de lijst van instrumenten  
        /// en stuurt het door naar de database om te verwijderen
        /// </summary>
        /// <param name="IndexInstr"></param>
        static public void InstrVerwijderen(int IndexInstr)
        {
           _naarDB.VerwDbInst(_lijstInstrumenten[IndexInstr]);
            VulLijsten();
        }


        /// <summary>
        /// Ontvangt de gegevens van een leerling, 
        /// maakt er een object van en stuurt dit naar de database
        /// om toe te voegen
        /// </summary>
        /// <param name="vnm"></param>
        /// <param name="anm"></param>
        /// <param name="ontvIndexInst"></param>
        static public void VoegLlnToe(string vnm, String anm, List<int> ontvIndexInst)
        {
           List<Instrument> tempInstLijst = new List<Instrument>();

            foreach (int idx in ontvIndexInst)
            {
                tempInstLijst.Add(_lijstInstrumenten[idx]);
            }

            Leerling nieuwLln = new Leerling(vnm, anm, tempInstLijst);
            _naarDB.ToevDbLln(nieuwLln);

            VulLijsten();
        }

        /// <summary>
        /// Ontvangt de gegevens van de GUI
        /// maakt een nieuw object van instrument met deze gegevens 
        /// en stuurt deze door naar de database
        /// </summary>
        /// <param name="ontvIndexLln"></param>
        /// <param name="vnm"></param>
        /// <param name="anm"></param>
        /// <param name="ontvIndexInst"></param>
        static public void LlnAanpassen(int ontvIndexLln, string vnm, String anm, List<int> ontvIndexInst)
        {
            List<Instrument> tempInstLijst = new List<Instrument>();

            foreach (int idx in ontvIndexInst)
            {
                tempInstLijst.Add(_lijstInstrumenten[idx]);
            }

            Leerling nieuwLln = new Leerling(_lijstLeerlingen[ontvIndexLln]._id,vnm, anm, tempInstLijst);
            _naarDB.AanpDbLln(nieuwLln);

            VulLijsten();

        }


        /// <summary>
        /// Neemy het juiste object uit de lijst van instrumenten  
        /// en stuurt het door naar de database om te verwijderen
        /// </summary>
        /// <param name="ontvIndexInst"></param>
        static public void LlnVerwijderen(int ontvIndexLln)
        {
           _naarDB.VerwDbLln(_lijstLeerlingen[ontvIndexLln]);
            VulLijsten();
        }

    }
}
