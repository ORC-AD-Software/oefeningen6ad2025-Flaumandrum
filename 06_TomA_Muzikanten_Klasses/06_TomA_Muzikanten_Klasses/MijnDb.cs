using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TomA_Muzikanten_Klasses
{
    public class MijnDb
    {
        // Velden
        static String _pad = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\School\Romero\23-24-25\2. Klassen\6_AD_ApplicatieEnDatabeheer\Oefeningen\VeelopVeel\Muzikanten_Afgewerkt\Proj_Muzikanten_opl.accdb";
        OleDbConnection _mijnconnectie = new OleDbConnection(_pad);

        // methoden

        // ophalen van gegevens
        public List<Leerling> LijstLeerlingen() 
        { 
            List<Leerling> lijstLln = new List<Leerling>();

            string sql = "SELECT * FROM Leerlingen";

            OleDbCommand command = new OleDbCommand(sql, _mijnconnectie);

            _mijnconnectie.Open();

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Leerling_ID"]);
                string voornaam = reader["Voornaam"].ToString();
                string achternaam = reader["Achternaam"].ToString();

                List<Instrument> instrumenten = InstrVanLln(id);

                Leerling lln = new Leerling(id, voornaam, achternaam, instrumenten);

                lijstLln.Add(lln);

            }
            _mijnconnectie.Close();


            return lijstLln;

        }

        public List<Instrument> InstrVanLln(int ontvId)
        {
            List<Instrument> lijstInstr = new List<Instrument>();

            /*String sql = $"SELECT i.Instrument_ID, i.InstrumentNaam, i.InstrumentGroep " +
                         $"FROM Instrumenten AS i " +
                         $"INNER JOIN InstrumentLeerlingen AS li ON i.Instrument_ID = li.Instrument_ID " +
                         $"WHERE li.Leerling_ID = {ontvId}";
            */

            String sql = $"SELECT Instrument_ID From InstrumentLeerlingen " +
                         $"WHERE Leerling_ID = {ontvId}";

            OleDbCommand command = new OleDbCommand(sql, _mijnconnectie);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int instrId = Convert.ToInt32(reader["Instrument_ID"]);
                Instrument instr = GegInstr(instrId);
                lijstInstr.Add(instr);
            }

            return lijstInstr;

        }

        public Instrument GegInstr(int ontvId)
        {
            Instrument instr = null;

            string sql = $"SELECT * FROM Instrumenten WHERE Instrument_ID = {ontvId}";

            OleDbCommand command = new OleDbCommand(sql, _mijnconnectie);

            OleDbDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                int id = Convert.ToInt32(reader["Instrument_ID"]);
                string naam = reader["InstrumentNaam"].ToString();
                string groep = reader["InstrumentGroep"].ToString();
                
                instr = new Instrument(id, naam, groep);
            }

            return instr;
        }

        public List<Instrument> LijstInstrumenten()
        {
            List<Instrument> lijstInstr = new List<Instrument>();

            string sql = "SELECT * FROM Instrumenten";

            OleDbCommand command = new OleDbCommand(sql, _mijnconnectie);
            _mijnconnectie.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Instrument_ID"]);
                string naam = reader["InstrumentNaam"].ToString();
                string groep = reader["InstrumentGroep"].ToString();

                List<Leerling> leerlingen = LlnVanInstr(id);

                Instrument instr = new Instrument(id, naam, groep, leerlingen);
                lijstInstr.Add(instr);
            }
            _mijnconnectie.Close();
            return lijstInstr;

        }

        public List<Leerling> LlnVanInstr(int ontvId)
        {
            List<Leerling> lijstLln = new List<Leerling>();

            String sql = $"SELECT Leerling_ID From InstrumentLeerlingen " +
                         $"WHERE Instrument_ID = {ontvId}";

            OleDbCommand command = new OleDbCommand(sql, _mijnconnectie);

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int llnId = Convert.ToInt32(reader["Leerling_ID"]);
                Leerling lln = GegLln(llnId);
                lijstLln.Add(lln);
            }
            return lijstLln;
        }

        public Leerling GegLln(int ontvId)
        {
            Leerling lln = null;
            string sql = $"SELECT * FROM Leerlingen WHERE Leerling_ID = {ontvId}";
            OleDbCommand command = new OleDbCommand(sql, _mijnconnectie);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Leerling_ID"]);
                string voornaam = reader["Voornaam"].ToString();
                string achternaam = reader["Achternaam"].ToString();
                lln = new Leerling(id, voornaam, achternaam);
            }
            return lln;
        }

        // toevoegen gegevens
        // toevoegen lln+ link inst
        public void ToevDbLln(Leerling ontvLln)
        {
            String  voorn = ontvLln._voornaam;
            String  achtern = ontvLln._achternaam;
            List<Instrument> instrs = ontvLln._instrumenten;

            // eerst leerling toevoegen
            string sql = "INSERT INTO Leerlingen (Voornaam, Achternaam) " +
                            $"VALUES ('{voorn}', '{achtern}')";
            OleDbCommand command = new OleDbCommand(sql, _mijnconnectie);

            _mijnconnectie.Open();

            command.ExecuteNonQuery();

            // daarna de link met instrumenten toevoegen
            if (instrs.Count() != 0)
            {
            }



            _mijnconnectie.Close();
        }
        
        // toevoegen instrument + link lln
        public void ToevDbInstr(Instrument ontvInstr)
        {
        }

        // aanpassen gegevens 
        // aanpassen leerling en link met inst
        public void AanpDbLln(Leerling ontvLln)
        {
        }

        // aanpassen instrument en link met lln
        public void AanpDbInst(Instrument ontvInstr)
        {
        }

        // verwijderen gegevens
        // verwijderen lln 
        public void VerwDbLln(Leerling ontvLln)
        {
        }

        // Verwijderen instrument
        public void VerwDbInst(Instrument ontvInstr)
        {
        }


    }
}
