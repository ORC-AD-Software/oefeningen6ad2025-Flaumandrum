using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TomA_VolgendeVakantie
{
    internal class Vakantie
    {
        // Velden (Fields)
        String _vakantienaam = null;
        DateTime _startDatum= DateTime.MinValue;
        DateTime _eindDatum = DateTime.MinValue;

        // Eigenschappen (Properties)
        public String PropVakantienaam
        {
            get { return _vakantienaam; }
            set { _vakantienaam = value; }
        }
        public DateTime PropStartDatum
        {
            get { return _startDatum; }
            set { _startDatum = value; }
        }
        
        public DateTime PropEindDatum
        {
            get { return _eindDatum; }
            set { _eindDatum = value; }
        }

        // Methoden (Methods)
        /// <summary>
        /// Kijkt of de ontvangen datum kleiner is dan de startdatum van de vakantie
        /// </summary>
        /// <param name="ontvDatum"></param>
        /// <returns></returns>
        public Boolean IsOntvDtKleiner(DateTime ontvDatum) 
        { 
            Boolean antwoord = false;

            if(ontvDatum < _startDatum)
            {
                antwoord = true;
            }

            return antwoord;
        }
        /// <summary>
        /// kijkt of de ontvangen datum binnen de start- en einddatum van de vakantie valt
        /// mogelijke antwoorden:
        ///     -1 = datum valt voor de vakantie, 
        ///     0 = datum valt binnen de vakantie, 
        ///     1 = datum valt na de vakantie
        /// </summary>
        /// <param name="ontvDatum"></param>
        /// <returns></returns>
        public SByte ValtDatumInVakantie(DateTime ontvDatum)
        {
            sbyte antwoord = 0;

            // Kijk of de datum voor de vakantie valt
            if (ontvDatum < _startDatum)
            {
                antwoord = -1;
            }

            // Kijk of de datum na de vakantie valt
            else if (ontvDatum > _eindDatum)
            {
                antwoord = 1;
            }

            // Anders valt de datum valt binnen de vakantie
            else
            {
                antwoord = 0;
            }

            return antwoord;
        }

        /// <summary>
        /// Geeft alle gegevens van de vakantie terug als een string
        /// + nieuwe lijn aan het einde
        /// </summary>
        /// <returns></returns>
        public String AlleGegevens()
        {
            String antwoord = null;

            antwoord = $"Vakantie: {_vakantienaam}, Startdatum: {_startDatum.ToShortDateString()}, Einddatum: {_eindDatum.ToShortDateString()}{Environment.NewLine}";

            return antwoord;
        }

        /// <summary>
        /// ontvangt een datum en geeft het aantal dagen terug tot aan de startdatum van de vakantie
        /// </summary>
        /// <param name="ontvDatum"></param>
        /// <returns></returns>
        public int Aantaldagen(DateTime ontvDatum)
        {
            int antwoord = 0;

            TimeSpan verschil = _startDatum - ontvDatum;
            antwoord = verschil.Days;

            return antwoord;
        }

        // Constructors
        // Default constructor
        public Vakantie(){}

        // Constructor met parameters
        public Vakantie(String ontvNm, DateTime ontvStDT, DateTime ontvEdDt) 
        { 
            _vakantienaam = ontvNm;
            _startDatum = ontvStDT;
            _eindDatum = ontvEdDt;
        }
    }
}
