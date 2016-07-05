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

using Com.Syncfusion.Charts;
using SQLite;

namespace sBike
{
    public class DataModel_Question1
    {
        public ObservableArrayList DataList;

        public DataModel_Question1()
        {
            DataList = new ObservableArrayList();

            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            string query = "SELECT COUNT(*) as FCount,Deelgemeente from Fietstrommels GROUP BY Deelgemeente ORDER BY COUNT(*) DESC LIMIT 5";
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item)
            {
                DataList.Add(new ChartDataPoint(row.Deelgemeente, row.FCount));
            }
        }
    }

    public class DataModel_Question2
    {
        public ObservableArrayList DataList;

        public DataModel_Question2()
        {
            DataList = new ObservableArrayList();

            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            string query = "select COUNT(*) as Thefts, strftime('%Y-%m', BeginDatum) as 'month_year' from Fietsdiefstal WHERE BeginDatum between '2011-01-01' and '2016-05-07' group by strftime('%Y-%m', BeginDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item)
            {
                DataList.Add(new ChartDataPoint(row.month_year, row.Thefts));
            }
        }
    }

    public class DataModel_Question3_1
    {
        public ObservableArrayList DataList;

        public DataModel_Question3_1()
        {
            DataList = new ObservableArrayList();

            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            string query = "select COUNT(*) as Thefts, strftime('%Y-%m', BeginDatum) as 'month_year' from Fietsdiefstal WHERE (BeginDatum between '2011-01-01' and '2016-05-07') and Werkgebied = 'RIDDERKERK' group by strftime('%Y-%m', BeginDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item)
            {
                DataList.Add(new ChartDataPoint(row.month_year, row.Thefts));
            }
        }
    }

    public class DataModel_Question3_2
    {
        public ObservableArrayList DataList;

        public DataModel_Question3_2()
        {
            DataList = new ObservableArrayList();

            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            string query = "select COUNT(*) as FCount, strftime('%Y-%m', MutDatum) as 'month_year' from Fietstrommels WHERE (MutDatum between '2011-01-01' and '2016-05-07') and Deelgemeente = 'Ridderkerk' group by strftime('%Y-%m', MutDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item)
            {
                DataList.Add(new ChartDataPoint(row.month_year, row.FCount));
            }
        }
    }

    

    public class DataModel_Question4
    {
        public ObservableArrayList DataList;

        public DataModel_Question4()
        {
            DataList = new ObservableArrayList();

            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            string query = "SELECT COUNT(*),Deelgemeente from Fietstrommels GROUP BY Deelgemeente ORDER BY COUNT(*) DESC LIMIT 5";
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item)
            {
                DataList.Add(new ChartDataPoint(row.Deelgemeente, row.FCount));
            }
        }
    }
}