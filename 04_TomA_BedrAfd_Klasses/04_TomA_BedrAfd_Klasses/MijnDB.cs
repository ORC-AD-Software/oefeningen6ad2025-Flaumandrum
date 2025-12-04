using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _04_TomA_BedrAfd_Klasses
{
    public class MijnDB
    {
        // Velden 
        static String _pad = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\School\Romero\23-24-25\2. Klassen\6_AD_ApplicatieEnDatabeheer\Oefeningen\Oefenigen 1opVeel\Project_Bedrijfsafdeling\ERD_en_Database\Proj_Bedrijfsafdeling.accdb";
        OleDbConnection _mijnConnectie = new OleDbConnection(_pad);

        // Methoden
        public List<Medewerker> HaalLijstWNOp()
        {
            // Maak een antwoord lijst aan
            List<Medewerker> lijstWn = new List<Medewerker>();

            // maak de sql query aan
            /*String sql = "SELECT Medewerkers.ID, Medewerkers.Voornaam, Medewerkers.Achternaam, Medewerkers.Statuut, Afdelingen.ID AS AfdID, Afdelingen.Naam AS AfdNaam, Afdelingen.Hoofd AS AfdHoofd " +
                         "FROM Medewerkers INNER JOIN Afdelingen ON Medewerkers.Afdeling = Afdelingen.ID"; */

            String sql = "SELECT * FROM Medewerkers";

            // maak het command object aan
            OleDbCommand mijnCommand = new OleDbCommand(sql, _mijnConnectie);

            // maak een reader aan
            OleDbDataReader mijnDataReader;

            // open de connectie
            _mijnConnectie.Open();

            // verbind de datareader met het command object
            mijnDataReader = mijnCommand.ExecuteReader();

            // lees de datareader uit
            while (mijnDataReader.Read()) 
            { 
                int id = (int)mijnDataReader["Id"];
                String voornaam = (String)mijnDataReader["Voornaam"];
                String achternaam = (String)mijnDataReader["Achternaam"];
                String statuut = (String)mijnDataReader["Werknemerstatuut"];
                int afdelingId = (int)mijnDataReader["IdAfdeling"];

                Medewerker wn = new Medewerker(id, voornaam, achternaam, statuut,HaalAfdVanWnOp(afdelingId));
                lijstWn.Add(wn);
            }

            // sluit de connectie
            _mijnConnectie.Close();

            return lijstWn;
        }

        public Afdeling HaalAfdVanWnOp( int ontvIdAfd)
        {
            // Maak een antwoord afdeling aan
            Afdeling afdeling = new Afdeling();

            // maak de sql query aan
            String sql = $"SELECT * FROM Afdeling WHERE Id = {ontvIdAfd}";

            // maak het command object aan
            OleDbCommand mijnCommand = new OleDbCommand(sql, _mijnConnectie);

            // maak een reader aan
            OleDbDataReader mijnDataReader;

            // verbind de datareader met het command object
            mijnDataReader = mijnCommand.ExecuteReader();

            // lees de datareader uit
            while (mijnDataReader.Read())
            {
                int id = (int)mijnDataReader["Id"];
                String afdelingsnaam = (String)mijnDataReader["Afdelingsnaam"];
                string afdelingshoofd = (String)mijnDataReader["Afdelingshoofd"];
                afdeling = new Afdeling(id, afdelingsnaam, afdelingshoofd);

            }

            return afdeling;
        }

        public List<Afdeling> HaalLijstAfdOp()
        {
            // Maak een antwoord lijst aan
            List<Afdeling> lijstAfd = new List<Afdeling>();

            // maak de sql query aan
            String sql = "SELECT * FROM Afdeling";

            // maak het command object aan
            OleDbCommand mijnCommand = new OleDbCommand(sql, _mijnConnectie);

            // maak een reader aan
            OleDbDataReader mijnDataReader;

            // open de connectie
            _mijnConnectie.Open();

            // verbind de datareader met het command object
            mijnDataReader = mijnCommand.ExecuteReader();

            // lees de datareader uit
            while (mijnDataReader.Read())
            {
                int id = (int)mijnDataReader["Id"];
                String afdNaam = (String)mijnDataReader["Afdelingsnaam"];
                String afdHoofd = (String)mijnDataReader["Afdelingshoofd"];

                Afdeling afd = new Afdeling(id, afdNaam, afdHoofd, HaalWnsAfdOp(id));
                lijstAfd.Add(afd);
            }

            // sluit de connectie
            _mijnConnectie.Close();

            return lijstAfd;
        }

        public List<Medewerker> HaalWnsAfdOp(int ontvIdAfd)
        {
            // antwoord lijst 
            List<Medewerker> lijstWn = new List<Medewerker>();

            // maak de sql query aan
            String sql = $"SELECT * FROM Medewerkers WHERE IdAfdeling = {ontvIdAfd}";

            // maak het command object aan
            OleDbCommand mijnCommand = new OleDbCommand(sql, _mijnConnectie);

            // maak een reader aan
            OleDbDataReader mijnDataReader;

            // verbind de datareader met het command object
            mijnDataReader = mijnCommand.ExecuteReader();

            // lees de datareader uit
            while (mijnDataReader.Read()) 
            {
                int id = (int)mijnDataReader["Id"];
                String voornaam = (String)mijnDataReader["Voornaam"];
                String achternaam = (String)mijnDataReader["Achternaam"];
                String statuut = (String)mijnDataReader["Werknemerstatuut"];

                Medewerker wn = new Medewerker(id, voornaam, achternaam, statuut);
                lijstWn.Add(wn);
            }

            return lijstWn;
        }

        public void VoegWNToe(Medewerker ontvWn)
        {
            int idWn = ontvWn._id;
            String voornaamWn = ontvWn._voornaam;
            String achternaamWn = ontvWn._achternaam;
            String statuutWn = ontvWn._statuut;

            int idAfdWn = ontvWn._afdeling._id;

            String sql = $"INSERT INTO Medewerkers (Voornaam, Achternaam, Werknemerstatuut, IdAfdeling) " +
                         $"VALUES ('{voornaamWn}', '{achternaamWn}', '{statuutWn}', {idAfdWn})";

            OleDbCommand mijnCommand = new OleDbCommand(sql, _mijnConnectie);

            _mijnConnectie.Open();

            mijnCommand.ExecuteNonQuery();

            _mijnConnectie.Close();


        }

        public void PasWnAan(Medewerker ontvWn)
        {

           
        }

        public void WnVerwijderen(Medewerker ontvWn)
        {

        }

        public void VoegAfdToe(Afdeling ontvAfd)
        {

        }

        public void PasAfdAan(Afdeling ontvAfd)
        {

        }

        public void AfdVerwijderen(Afdeling ontvAfd)
        {

        }

    }
}
