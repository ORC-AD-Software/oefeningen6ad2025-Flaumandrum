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

        // Constructors

    }
}
