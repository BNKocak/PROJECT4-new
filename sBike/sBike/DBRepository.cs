using System;
using System.Globalization;
using System.Data;
using System.IO;
using SQLite;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace sBike
{

    public class DBRepository
    {
        //string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormdemo.db3");
        SQLiteConnection db = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormdemo.db3"));

        //code to create the database
        public string CreateDB()
        {

            var output = "";
            output += "Creating Database if it doesnt exist.";
            var db = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "ormdemo.db3"));
            output += "\nDatabase Created...";
            return output;
        }

        //Code to create the tabel
        public string CreateTable()
        {
            try
            {
                db.CreateTable<Fietstrommels>();
                db.CreateTable<Fietsdiefstal>();
                db.CreateTable<DBAddress>();
                string result = "Table Created successfully..";
                return result;
            }
            catch (Exception ex)
            {
                return "Error : " + ex.Message;
            }
        }

        // Code to insert record
        public string InsertContainers(string[] row)
        {
            try
            { 
                DateTime temp_datetime;
                //string x;
                //if (DateTime.TryParse(row[9], out xx))
                //{
                //    item.MutDatum = xx.ToString("yyyyMMdd");
                //}

                CultureInfo provider = CultureInfo.InvariantCulture;
                string format = "dd-MM-yyyy";

                Fietstrommels item = new Fietstrommels();
                item.InvNr = row[0];
                item.InvSrt = row[1];
                item.Omschrijving = row[2];
                item.Straat = row[3];
                item.Thv = row[4];
                item.XCoord = float.Parse(row[5]);
                item.YCoord = float.Parse(row[6]);
                item.Deelgemeente = row[7];
                item.Status = row[8];
                temp_datetime = DateTime.ParseExact(row[9], format, provider);
                item.MutDatum = temp_datetime.ToString("yyyy-MM-dd");
                item.User = row[10];
                db.Insert(item);


                Console.WriteLine(row);
                return "Records Added...";
            }
            catch (Exception ex)
            {
                return "Error : " + ex.Message;
            }
        }

        public string InsertThefts(string[] row)
        {
            try
            {
                DateTime temp_datetime;
                CultureInfo provider = CultureInfo.InvariantCulture;

                Fietsdiefstal item = new Fietsdiefstal();
                item.VNr = row[0];
                item.Kennisname = row[1];
                item.MK = row[2];
                item.MKOmschrijving = row[3];
                item.Poging = row[4];
                item.District = row[5];
                item.Werkgebied = row[6];
                item.Plaats = row[7];
                item.Buurt = row[8];
                item.Straat = row[9];
                item.BeginDagsoort = row[10];
                temp_datetime = DateTime.ParseExact(row[11], "dd/MM/yyyy", provider); ;
                item.BeginDatum = temp_datetime.ToString("yyyy-MM-dd");
                item.BeginTijd = row[12];
                item.EindDagsoort = row[13];
                item.EindDatum = row[14];
                item.EindTijd = row[15];
                item.GemJaar = row[16];
                item.GemMaand = row[17];
                item.GemDagsoort = row[18];
                item.GemDagsoortUren = row[19];
                item.Trefwoord = row[20];
                item.Object = row[21];
                item.Merk = row[22];
                item.Type = row[23];
                item.Kleur = row[24];
                db.Insert(item);
                return "Records Added...";
            }
            catch (Exception ex)
            {
                return "Error : " + ex.Message;
            }
        }

        //code to retrieve all the records
        public string GetAllRecords()
        {

            string output = "";
            output += "Retrieving the data using ORM...";
            //var table = db.Query("SELECT COUNT(*),Deelgemeente from Fietstrommels GROUP BY Deelgemeente ORDER BY COUNT(*) DESC LIMIT 5", null);
            var table = db.Table<Fietsdiefstal>();
            foreach (var item in table)
            {
                output += "\n" + item.Plaats + " --- " + item.BeginDatum;
            }
            return output;
        }

        //code to receive vraag 1 data
        public string GetVraag1()
        {
            string output = "";
            string query = "SELECT COUNT(*) as FCount,Deelgemeente from Fietstrommels GROUP BY Deelgemeente ORDER BY COUNT(*) DESC LIMIT 5";
            int i = 0;
            int[] FCount = { 222, 168, 88, 78, 56 };
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item)
            {
                output += "\n" + row.Deelgemeente + " --- " + row.FCount;
                i++;
            }
            return output;
        }

        public string GetVraag2()
        {
            string output2 = "";
            string query_2 = "SELECT COUNT(*) as Vraag2, Deelgemeente from Fietstrommels WHERE MutDatum between '2001-01-01' and '2014-01-01'";
            string query_3 = "select COUNT(*) as Vraag2, strftime('%m-%Y', MutDatum) as 'month_year' from Fietstrommels group by strftime('%m-%Y', MutDatum)";
            var item = db.Query<Fietsdiefstal>(query_3);
            foreach (var row in item)
            {
                output2 += "\n" + row.month_year + " --- " + row.Thefts;
            }
            return output2;
        }

        public string GetVraag4()
        {
            string output2 = "";
            string query = "SELECT COUNT(*) as Thefts, Werkgebied FROM Fietsdiefstal GROUP BY Werkgebied";
            string query_1 = "SELECT DISTINCT Werkgebied FROM Fietsdiefstal";
            string query_2 = "select COUNT(*) as Vraag2, strftime('%m-%Y', MutDatum) as 'month_year' from Fietstrommels group by strftime('%m-%Y', MutDatum)";
            string query_3 = "select COUNT(*) as FCount, strftime('%Y-%m', MutDatum) as 'month_year' from Fietstrommels WHERE (MutDatum between '2011-01-01' and '2016-05-07') group by strftime('%Y-%m', MutDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietstrommels>(query_3);
            foreach (var row in item)
            {
                output2 += "\n" + row.month_year + "---" + row.FCount;
            }
            Console.Write(output2);
            return output2;

        }

        public void deleteData()
        {
            db.Query<Fietstrommels>("DELETE FROM Fietstrommels");
            db.Query<Fietstrommels>("DELETE FROM Fietsdiefstal");
        }
    }
}