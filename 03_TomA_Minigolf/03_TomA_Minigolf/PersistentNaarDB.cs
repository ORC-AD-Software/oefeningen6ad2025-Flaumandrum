using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _03_TomA_Minigolf
{
    internal class PersistentNaarDB
    {
        // Velden
        static String _mijnPad = "";
        OleDbConnection _mijnConnectie = new OleDbConnection(_mijnPad);

        // Porperties (niet deel van deze cursus)

        // Methode
        /// <summary>
        /// haalt de lijst van spelers op uit de database
        /// </summary>
        /// <returns></returns>
        public List<Speler> GetSpelers()
        { 
        
        }

        /// <summary>
        /// ontvangt een object van het type Speler en voegt deze toe aan de database
        /// </summary>
        /// <param name="ontvSpeler">object van type speler</param>
        public void DbToevoegenSpeler(Speler ontvSpeler)
        {

        }

        /// <summary>
        /// ontvangt een object van het type Speler en past deze aan in de database
        /// </summary>
        /// <param name="ontvSpeler">object van type speler</param>
        public void DbAanpassenSpeler(Speler ontvSpeler)
        {

        }

        /// <summary>
        /// ontvangt een object van het type Speler en verwijdert deze uit de database
        /// </summary>
        /// <param name="ontvSpeler">object van type speler</param>
        public void DbVerwijderSpeler(Speler ontvSpeler) 
        { 
        
        }

        /// <summary>
        /// reset de database naar de begin situatie
        /// </summary>
        public void DbReset()
        { 
        
        }


    }
}
