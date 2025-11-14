using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_TomA_BedrAfd_Klasses
{
    public class Medewerker
    {
        // Velden 
        int _id = 0;
        string _voornaam = "";
        string _achternaam = "";
        string statuut= "";
        Afdeling _afdeling = new Afdeling();

        // Properties


        // Methoden
        public string GetAfdelingEnHoofd() 
        { 
            return _afdeling.GetGegevensAfdeling();
        }
        public string GetVolledigeNaam()
        {
            return $"{_voornaam} {_achternaam}";
        }
        public string GetNaamStatuut()
        {
            return $"{_voornaam} {_achternaam} - {statuut}";
        }
        public string GetAlleGegevensMedewerker()
        {
            String antwoord = "";
            
            antwoord += $"{GetNaamStatuut()}\n   Afdeling {GetAfdelingEnHoofd()}";

            return antwoord;
        }

        // Constructors

    }
}
