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
        static String _mijnPad = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\School\Romero\23-24-25\2. Klassen\6_AD_ApplicatieEnDatabeheer\Oefeningen\Databank\Minigolf.accdb";
        OleDbConnection _mijnConnectie = new OleDbConnection(_mijnPad);

        // Porperties (niet deel van deze cursus)

        // Methode
        /// <summary>
        /// haalt de lijst van spelers op uit de database
        /// </summary>
        /// <returns></returns>
        public List<Speler> GetSpelers()
        { 
            List<Speler> spelersLijst = new List<Speler>();

            // maak een sql query om de speler toe te voegen aan de database
            string sqlQuery = $"SELECT * FROM Speler";

            // maak een commando om de query uit te voeren
            OleDbCommand mijnCommand = new OleDbCommand(sqlQuery, _mijnConnectie);

            // maak een datareader om de resultaten van het commando op te vangen
            OleDbDataReader mijnDataReader;

            // open de connectie, voer het commando uit en sluit de connectie
            _mijnConnectie.Open();

            // verbind de datareader met het commando 
            mijnDataReader = mijnCommand.ExecuteReader();

            while (mijnDataReader.Read())
            {
                // Haal de gegevens op uit de datareader en steek ze in een lokale variabele
                int id = Convert.ToInt32(mijnDataReader["Id"]);
                string voornaam = Convert.ToString(mijnDataReader["Voornaam"]);
                string naam = Convert.ToString(mijnDataReader["Familienaam"]);
                int totaalSlagen = Convert.ToInt32(mijnDataReader["TotaalSlagen"]); 

                // Maak een object van speler
                Speler tempSpeler = new Speler(id, voornaam, naam, totaalSlagen);

                spelersLijst.Add(tempSpeler);

            }

            _mijnConnectie.Close();

            return spelersLijst;
        }

        /// <summary>
        /// ontvangt een object van het type Speler en voegt deze toe aan de database
        /// </summary>
        /// <param name="ontvSpeler">object van type speler</param>
        public void DbToevoegenSpeler(Speler ontvSpeler)
        {
            // neem de nodige gegevens uit het object ontvSpeler
            string voornaam = ontvSpeler.PropVoornaam;
            string naam = ontvSpeler.PropNaam;
            
            // maak een sql query om de speler toe te voegen aan de database
            string sqlQuery = $"INSERT INTO Speler (Voornaam, Familienaam, TotaalSlagen) VALUES ('{voornaam}', '{naam}', 0)";

            // maak een commando om de query uit te voeren
            OleDbCommand mijnCommand = new OleDbCommand(sqlQuery, _mijnConnectie);

            // open de connectie, voer het commando uit en sluit de connectie
            _mijnConnectie.Open();
            mijnCommand.ExecuteNonQuery();
            _mijnConnectie.Close();

        }

        /// <summary>
        /// ontvangt een object van het type Speler en past deze aan in de database
        /// </summary>
        /// <param name="ontvSpeler">object van type speler</param>
        public void DbAanpassenSpeler(Speler ontvSpeler)
        {
            // neem de nodige gegevens uit het object ontvSpeler
            int id = ontvSpeler.PropId;
            string voornaam = ontvSpeler.PropVoornaam;
            string naam = ontvSpeler.PropNaam;
            int totaalSlagen = ontvSpeler.PropTotaalSlagen;

            // maak een sql query om de speler toe te voegen aan de database
            string sqlQuery = $"UPDATE Speler SET Voornaam = '{voornaam}',Familienaam = '{naam}', TotaalSlagen = {totaalSlagen} WHERE Id = {id}";

            // maak een commando om de query uit te voeren
            OleDbCommand mijnCommand = new OleDbCommand(sqlQuery, _mijnConnectie);

            // open de connectie, voer het commando uit en sluit de connectie
            _mijnConnectie.Open();
            mijnCommand.ExecuteNonQuery();
            _mijnConnectie.Close();
        }

        /// <summary>
        /// ontvangt een object van het type Speler en verwijdert deze uit de database
        /// </summary>
        /// <param name="ontvSpeler">object van type speler</param>
        public void DbVerwijderSpeler(Speler ontvSpeler) 
        {
            // neem de nodige gegevens uit het object ontvSpeler
            int id = ontvSpeler.PropId;

            // maak een sql query om de speler toe te voegen aan de database
            string sqlQuery = $"DELETE FROM Speler WHERE Id = {id}";

            // maak een commando om de query uit te voeren
            OleDbCommand mijnCommand = new OleDbCommand(sqlQuery, _mijnConnectie);

            // open de connectie, voer het commando uit en sluit de connectie
            _mijnConnectie.Open();
            mijnCommand.ExecuteNonQuery();
            _mijnConnectie.Close();
        }

        /// <summary>
        /// reset de database naar de begin situatie
        /// </summary>
        public void DbReset()
        {
            // maak een sql query om de speler toe te voegen aan de database
            string sqlQuery = $"DELETE FROM Speler";

            // maak een commando om de query uit te voeren
            OleDbCommand mijnCommand = new OleDbCommand(sqlQuery, _mijnConnectie);

            // open de connectie, voer het commando uit en sluit de connectie
            _mijnConnectie.Open();
            mijnCommand.ExecuteNonQuery();
            _mijnConnectie.Close();
        }


    }
}
