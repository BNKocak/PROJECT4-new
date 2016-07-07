using System;
using System.Globalization;
using System.Data;
using System.IO;
using SQLite;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using Android.Content.Res;
using Android.App;

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

        void ReadandParseData(string path, char seperator, string identifier, Activity src)
        {
            var parsedData = new List<string[]>();
            int cnt2 = 0;
            AssetManager assets = src.Assets;
            using (var sr = new StreamReader(assets.Open(path)))
            {
                db.BeginTransaction();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    cnt2++;
                    string[] row = line.Split(seperator);
                    if (identifier == "bikecontainers")
                    {
                        InsertContainers(row);
                    }
                    else if (identifier == "bikethefts")
                    {
                        InsertThefts(row);
                    }
                }
                db.Commit();
            }
        }
        public string InsertContainers(string[] row)
        {
            try
            {
                DateTime temp_datetime;

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

        public void AddRecord(Activity src)
        {
            //StartActivity(typeof(InsertTask_Activity));
            //DBRepository dbr = new DBRepository();
            //string csvdir = System.Environment.CurrentDirectory;
            //ExploreDirectories("/storage/extSdCard");
            //var x = Directory.GetDirectories(csvdir);
            //string[] test = File.ReadAllLines(csvpath);
            //string[] files = Directory.GetFiles(csvdir);
            //File.Copy("Fietstrommels.csv", csvpath);

            //string csvpath1 = Path.Combine("/storage/extSdCard", "Fietstrommels.csv");
            ReadandParseData("Fietstrommels.csv", ',', "bikecontainers", src);
            ReadandParseData("fietsdiefstal-rotterdam-2011-2013.csv", ',', "bikethefts", src);
        }

        public void deleteData()
        {
            db.Query<Fietstrommels>("DELETE FROM Fietstrommels");
            db.Query<Fietstrommels>("DELETE FROM Fietsdiefstal");
        }
    }
}