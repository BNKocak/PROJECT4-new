using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;

namespace sBike
{
    [Activity(Label = "Database")]
    public class database_Activity : Activity
    {
        DBRepository connection = new DBRepository();

        void ReadandParseData(string path, char seperator, string identifier)
        {
            var parsedData = new List<string[]>();
            string[] test = File.ReadAllLines(path);
            int cnt2 = 0;
            using (var sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    cnt2++;
                    string[] row = line.Split(seperator);
                    if (identifier == "bikecontainers")
                    {
                        connection.InsertContainers(row);
                    }
                    else if (identifier == "bikethefts")
                    {
                        connection.InsertThefts(row);
                    }
                }
                Toast.MakeText(this, "Amount of records added in " + identifier + ":" + cnt2.ToString(), ToastLength.Short).Show();
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Database);

            //create the database
            Button btnCreateDB = FindViewById<Button>(Resource.Id.btnCreateDB);
            btnCreateDB.Click += btnCreateDB_Click;

            // create table
            Button btnCreateTable = FindViewById<Button>(Resource.Id.btnCreateTable);
            btnCreateTable.Click += btnCreateTable_Click;

            // To Insert the record
            Button btnAddRecord = FindViewById<Button>(Resource.Id.btnInstert);
            btnAddRecord.Click += btnAddRecord_Click;

            // to retrieve the data
            Button btnGetAll = FindViewById<Button>(Resource.Id.btnGetData);
            btnGetAll.Click += btnGetAll_Click;

            // to retrieve specifick record
            Button btnGetById = FindViewById<Button>(Resource.Id.btnGetDataByID);
            btnGetById.Click += btnGetById_Click;

            // delete
            Button btnDel = FindViewById<Button>(Resource.Id.btnDelete);
            btnDel.Click += btnDelAll_Click;
        }

        void btnGetById_Click(object sender, EventArgs e)
        {
            DBRepository dbr = new DBRepository();
            var result = dbr.GetVraag4();
            Toast.MakeText(this, result, ToastLength.Short).Show();
        }
        void btnGetAll_Click(object sender, EventArgs e)
        {
            DBRepository dbr = new DBRepository();
            var result = dbr.GetAllRecords();
            Toast.MakeText(this, result, ToastLength.Short).Show();
        }

        void btnDelAll_Click(object sender, EventArgs e)
        {
            DBRepository dbr = new DBRepository();
            dbr.deleteData();
        }
        static void ExploreDirectories(string root)
        {
            var directories = Directory.GetDirectories(root);
            if (directories.Count() == 0)
                return;
            foreach(var d in directories)
            {
                ExploreDirectories(d);
            }
        }
        void btnAddRecord_Click(object sender, EventArgs e)
        {
            //StartActivity(typeof(InsertTask_Activity));
            //DBRepository dbr = new DBRepository();
            //string csvdir = System.Environment.CurrentDirectory;
            //ExploreDirectories("/storage/extSdCard");
            //var x = Directory.GetDirectories(csvdir);
            //string[] test = File.ReadAllLines(csvpath);
            //string[] files = Directory.GetFiles(csvdir);
            //File.Copy("Fietstrommels.csv", csvpath);

            string csvpath1 = Path.Combine("/storage/extSdCard", "Fietstrommels.csv");
            string csvpath2 = Path.Combine("/storage/extSdCard", "fietsdiefstal-rotterdam-2011-2013.csv");
            string csvpath3 = Path.Combine("/data/data/sBike.sBike/files", "Fietstrommels.csv");
            string csvpath4 = Path.Combine("/data/data/sBike.sBike/files", "fietsdiefstal-rotterdam-2011-2013.csv");

            //ReadandParseData(csvpath1, ',', "bikecontainers");
            //ReadandParseData(csvpath2, ',', "bikethefts");
            ReadandParseData(csvpath3, ',', "bikecontainers");
            ReadandParseData(csvpath4, ',', "bikethefts");
        }
        void btnCreateTable_Click(Object sender, EventArgs e)
        {
            DBRepository dbr = new DBRepository();
            var result = dbr.CreateTable();
            Toast.MakeText(this, result, ToastLength.Short).Show();
        }
        void btnCreateDB_Click(object sender, EventArgs e)
        {
            DBRepository dbr = new DBRepository();
            var result = dbr.CreateDB();
            Toast.MakeText(this, result, ToastLength.Short).Show();

        }
    }
}