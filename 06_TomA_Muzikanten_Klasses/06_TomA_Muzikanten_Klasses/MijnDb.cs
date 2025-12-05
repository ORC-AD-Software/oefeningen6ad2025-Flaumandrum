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
                foreach (Instrument i in instrs)
                {
                    string sqlLink = "INSERT INTO InstrumentLeerling (Instrument_ID, Leerling_ID) " +
                                     $"VALUES ({i._id}, {ontvLln._id})";
                    OleDbCommand commandLink = new OleDbCommand(sqlLink, _mijnconnectie);
                    commandLink.ExecuteNonQuery();
                }

            }

            _mijnconnectie.Close();
        }
        
        // toevoegen instrument + link lln
        public void ToevDbInstr(Instrument ontvInstr)
        {
            string naam = ontvInstr._naam;
            string groep = ontvInstr._groep;
            List<Leerling> llns = ontvInstr._leerlingen;

            // eerst instrument toevoegen
            string sql = "INSERT INTO Instrumenten (InstrumentNaam, InstrumentGroep) " +
                            $"VALUES ('{naam}', '{groep}')";

            OleDbCommand command = new OleDbCommand(sql, _mijnconnectie);
            _mijnconnectie.Open();
            command.ExecuteNonQuery();

            // kijk of er een link met leerling moet toegevoegd worden
            if(llns.Count() != 0)
            {
                foreach(Leerling l in llns)
                {
                    string sqlLink = "INSERT INTO InstrumentLeerling (Instrument_ID, Leerling_ID) " +
                                     $"VALUES ({ontvInstr._id}, {l._id})";
                    OleDbCommand commandLink = new OleDbCommand(sqlLink, _mijnconnectie);
                    commandLink.ExecuteNonQuery();
                }
            }



            _mijnconnectie.Close();
        }

        // aanpassen gegevens 
        // aanpassen leerling en link met inst
        public void AanpDbLln(Leerling ontvLln)
        {
            int id = ontvLln._id;
            String voorn = ontvLln._voornaam;
            String achtern = ontvLln._achternaam;
            List<Instrument> instrs = ontvLln._instrumenten;

            // eerst leerling toevoegen
            string sql = $"UPDATE Leerlingen SET Voornaam ='{voorn}', Achternaam = '{achtern}' WHERE Leerling_ID = {id}";
            OleDbCommand command = new OleDbCommand(sql, _mijnconnectie);

            _mijnconnectie.Open();

            command.ExecuteNonQuery();

            // Haal de oude lijst met instrumementen op
            List<Instrument> oudeInstrs = InstrVanLln(id);

            // vergelijk de welke instrumenten verwijderd zijn uit de oude lijst 
            /*
               foreach (Instrument oudInstr in oudeInstrs)
             {
                 if (!instrs.Contains(oudInstr))
                 {
                     // Verwijder de link
                     string sqlVerw = $"DELETE FROM InstrumentLeerlingen WHERE Leerling_ID = {id} AND Instrument_ID = {oudInstr._id}";
                     OleDbCommand commandVerw = new OleDbCommand(sqlVerw, _mijnconnectie);
                     commandVerw.ExecuteNonQuery();
                 }
             }

              */

            
            foreach (Instrument i in oudeInstrs)
            {
                bool gevonden = false;
                int  idOudeLijst = i._id;

                foreach (Instrument i2 in instrs)
                {
                    int idNieuweLijst = i2._id;
                    if (idOudeLijst == idNieuweLijst)
                    {
                        gevonden = true;
                        break;
                    }
                }

                if(gevonden == false)
                {
                    // Verwijder de link
                    string sqlVerw = $"DELETE FROM InstrumentLeerling WHERE Leerling_ID = {id} AND Instrument_ID = {idOudeLijst}";
                    OleDbCommand commandVerw = new OleDbCommand(sqlVerw, _mijnconnectie);
                    commandVerw.ExecuteNonQuery();
                }
            }


            // vergelijk de welke instrumenten toegevoegd zijn in de nieuwe lijst
            /*
               foreach (Instrument nieuwInstr in instrs)
             {
                 if (!oudeInstrs.Contains(nieuwInstr))
                 {
                     // Verwijder de link
                     string sqlToev = $"INSERT INTO InstrumentLeerling (Instrument_ID, Leerling_ID) " +
                                     $"VALUES ({idNieuweLijst}, {id})";
                     OleDbCommand commandToev = new OleDbCommand(sqlToev, _mijnconnectie);
                     commandVerw.ExecuteNonQuery();
                 }
             }

              */
            foreach (Instrument nieuwInstr in instrs)
            {
                bool gevonden = false;
                int idNieuweLijst = nieuwInstr._id;
                foreach (Instrument oudInstr in oudeInstrs)
                {
                    int idOudeLijst = oudInstr._id;
                    if (idNieuweLijst == idOudeLijst)
                    {
                        gevonden = true;
                        break;
                    }
                }
                if (gevonden == false)
                {
                    // Voeg de link toe
                    string sqlToev = $"INSERT INTO InstrumentLeerling (Instrument_ID, Leerling_ID) " +
                                     $"VALUES ({idNieuweLijst}, {id})";
                    OleDbCommand commandToev = new OleDbCommand(sqlToev, _mijnconnectie);
                    commandToev.ExecuteNonQuery();
                }
            }


            _mijnconnectie.Close();

        }

        // aanpassen instrument en link met lln
        public void AanpDbInst(Instrument ontvInstr)
        {
            // haal gegevens op
            int id = ontvInstr._id;
            string naam = ontvInstr._naam;
            string groep = ontvInstr._groep;
            List<Leerling> llns = ontvInstr._leerlingen;

            // eerst instrument aanpassen
            string sql = $"UPDATE Instrumenten SET InstrumentNaam ='{naam}', InstrumentGroep = '{groep}' WHERE Instrument_ID = {id}";

            OleDbCommand command = new OleDbCommand(sql, _mijnconnectie);
            _mijnconnectie.Open();
            command.ExecuteNonQuery();

            // haal oude lijst met leerlingen op
            List<Leerling> oudeLlns = LlnVanInstr(id);

            // vergelijk welke leerlingen verwijderd zijn uit de oude lijst
            /*
             foreach (Leerling oudLln in oudeLlns)
             {
                 if (!llns.Contains(oudLln))
                 {
                     // Verwijder de link
                     string sqlVerw = $"DELETE FROM InstrumentLeerling WHERE Instrument_ID = {id} AND Leerling_ID = {idOudeLijst}";
                    OleDbCommand commandVerw = new OleDbCommand(sqlVerw, _mijnconnectie);
                    commandVerw.ExecuteNonQuery();
                 }
             }
             
             */


            foreach (Leerling oudLln in oudeLlns)
            {
                bool gevonden = false;
                int idOudeLijst = oudLln._id;
                foreach (Leerling l2 in llns)
                {
                    int idNieuweLijst = l2._id;
                    if (idOudeLijst == idNieuweLijst)
                    {
                        gevonden = true;
                        break;
                    }
                }
                if (gevonden == false)
                {
                    // Verwijder de link
                    string sqlVerw = $"DELETE FROM InstrumentLeerling WHERE Instrument_ID = {id} AND Leerling_ID = {idOudeLijst}";
                    OleDbCommand commandVerw = new OleDbCommand(sqlVerw, _mijnconnectie);
                    commandVerw.ExecuteNonQuery();
                }


                // vergelijk welke leerlingen toegevoegd zijn in de nieuwe lijst
                /*
                 foreach (Leerling lln in llns)
                 {
                     if (!oudeLlns.Contains(lln))
                     {
                         // Verwijder de link
                        string sqlToev = $"INSERT INTO InstrumentLeerling (Instrument_ID, Leerling_ID) " +
                                         $"VALUES ({id}, {idNieuweLijst})";
                        OleDbCommand commandToev = new OleDbCommand(sqlToev, _mijnconnectie);
                        commandToev.ExecuteNonQuery();
                     }
                 }
             
                 */


                foreach (Leerling nieuwLln in llns)
                {
                    bool gevonden2 = false;
                    int idNieuweLijst = nieuwLln._id;
                    foreach (Leerling oudLln2 in oudeLlns)
                    {
                        int idOudeLijst2 = oudLln2._id;
                        if (idNieuweLijst == idOudeLijst2)
                        {
                            gevonden2 = true;
                            break;
                        }
                    }
                    if (gevonden2 == false)
                    {
                        // Voeg de link toe
                        string sqlToev = $"INSERT INTO InstrumentLeerling (Instrument_ID, Leerling_ID) " +
                                         $"VALUES ({id}, {idNieuweLijst})";
                        OleDbCommand commandToev = new OleDbCommand(sqlToev, _mijnconnectie);
                        commandToev.ExecuteNonQuery();
                    }
                }
            }




            _mijnconnectie.Close();
        }

        // verwijderen gegevens
        // verwijderen lln 
        public void VerwDbLln(Leerling ontvLln)
        {
            int id = ontvLln._id;

            string sql = $"DELETE FROM Leerlingen WHERE Leerling_ID = {id}";
            OleDbCommand command = new OleDbCommand(sql, _mijnconnectie);
            _mijnconnectie.Open();

            command.ExecuteNonQuery();

            _mijnconnectie.Close();

        }

        // Verwijderen instrument
        public void VerwDbInst(Instrument ontvInstr)
        {
            int id = ontvInstr._id;
            string sql = $"DELETE FROM Instrumenten WHERE Instrument_ID = {id}";
            OleDbCommand command = new OleDbCommand(sql, _mijnconnectie);

            _mijnconnectie.Open();
            command.ExecuteNonQuery();
            _mijnconnectie.Close();

        }


    }
}
