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
    public class DataModel
    {
        ObservableArrayList DataList;
        static string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ormdemo.db3");
        SQLiteConnection db = new SQLiteConnection(dbPath);

        public ObservableArrayList Question1()
        {
            string query = "SELECT COUNT(*) as FCount,Deelgemeente from Fietstrommels GROUP BY Deelgemeente ORDER BY COUNT(*) DESC LIMIT 5";
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item)
            {
                DataList.Add(new ChartDataPoint(row.Deelgemeente, row.FCount));
            }

            return DataList;
        }

        public ObservableArrayList Question2()
        {
            string query = "select COUNT(*) as Thefts, strftime('%Y-%m', BeginDatum) as 'month_year' from Fietsdiefstal WHERE BeginDatum between '2011-01-01' and '2016-05-07' group by strftime('%Y-%m', BeginDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item)
            {
                DataList.Add(new ChartDataPoint(row.month_year, row.Thefts));
            }

            return DataList;
        }

        public ObservableArrayList Question3_1()
        {
            string query = "select COUNT(*) as Thefts, strftime('%Y-%m', BeginDatum) as 'month_year' from Fietsdiefstal WHERE (BeginDatum between '2001-01-01' and '2016-05-07') and Werkgebied = 'STAD' group by strftime('%Y-%m', BeginDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item)
            {
                DataList.Add(new ChartDataPoint(row.month_year, row.Thefts));
            }

            return DataList;
        }
        public ObservableArrayList NOORD()
        {
            string query = "select COUNT(*) as Thefts, strftime('%Y-%m', BeginDatum) as 'month_year' from Fietsdiefstal WHERE (BeginDatum between '2001-01-01' and '2016-05-07') and (Werkgebied = 'RIDDERKERK' or Werkgebied = 'ALEXANDER NOORD' or Werkgebied = 'Capelle' or Werkgebied = 'Krimpen') group by strftime('%Y-%m', BeginDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.Thefts)); }
            return DataList;
        }
        public ObservableArrayList CENTRUM()
        {
            string query = "select COUNT(*) as Thefts, strftime('%Y-%m', BeginDatum) as 'month_year' from Fietsdiefstal WHERE (BeginDatum between '2001-01-01' and '2016-05-07') and (Werkgebied = 'SCHEEPSVAARTKWARTIER/COOL' or Werkgebied = 'SCHIEDAM' or Werkgebied = 'NW WESTEN/MIDDELAND' or Werkgebied = 'STAD' or Werkgebied = 'OUDE WESTEN' or Werkgebied = 'BINNENROTTE/OUDE HAVEN' or Werkgebied = 'WALENBURGERWEG/OUDE NOORDEN') group by strftime('%Y-%m', BeginDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.Thefts)); }
            return DataList;
        }
        public ObservableArrayList FEIJNOORD()
        {
            string query = "select COUNT(*) as Thefts, strftime('%Y-%m', BeginDatum) as 'month_year' from Fietsdiefstal WHERE (BeginDatum between '2001-01-01' and '2016-05-07') and (Werkgebied = 'RIDDERKERK' or Werkgebied = 'BLOEMHOF/HILLESLUIS/VREEWIJK') group by strftime('%Y-%m', BeginDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.Thefts)); }
            return DataList;
        }
        public ObservableArrayList HILLEGERSBERG()
        {
            string query = "select COUNT(*) as Thefts, strftime('%Y-%m', BeginDatum) as 'month_year' from Fietsdiefstal WHERE (BeginDatum between '2001-01-01' and '2016-05-07') and (Werkgebied = 'LANSLINGERLAND' or Werkgebied = 'SCHIEBROEK/HILLEGERSBERG') group by strftime('%Y-%m', BeginDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.Thefts)); }
            return DataList;
        }
        public ObservableArrayList OVERSCHIE()
        {
            string query = "select COUNT(*) as Thefts, strftime('%Y-%m', BeginDatum) as 'month_year' from Fietsdiefstal WHERE (BeginDatum between '2001-01-01' and '2016-05-07') and (Werkgebied = 'OVERSCHIE' or Werkgebied = 'KRALINGEN' or Werkgebied = 'CROOSWIJK' or Werkgebied = 'VLAARDINGEN' or Werkgebied = 'MARCONIPLEIN') group by strftime('%Y-%m', BeginDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.Thefts)); }
            return DataList;
        }
        public ObservableArrayList CHARLOIS()
        {
            string query = "select COUNT(*) as Thefts, strftime('%Y-%m', BeginDatum) as 'month_year' from Fietsdiefstal WHERE (BeginDatum between '2001-01-01' and '2016-05-07') and (Werkgebied = 'TARWEWIJK/OUDE-CHARLOIS/CARNISSE/ZUIDWIJK/PENDRECHT' or Werkgebied = 'BEVERWAARD' or Werkgebied = 'MAASHAVEN' or Werkgebied = 'ALEXANDER ZUID' or Werkgebied = 'BLOEMHOF' or Werkgebied = 'MAASSLUIS' or Werkgebied = 'HOEK VAN HOLLAND' or Werkgebied = 'ALBRANDSWAARD') group by strftime('%Y-%m', BeginDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.Thefts)); }
            return DataList;
        }
        public ObservableArrayList IJSELMONDE()
        {
            string query = "select COUNT(*) as Thefts, strftime('%Y-%m', BeginDatum) as 'month_year' from Fietsdiefstal WHERE (BeginDatum between '2001-01-01' and '2016-05-07') and (Werkgebied = 'BARENDRECHT' or Werkgebied = 'GOERRE-OVERFLAKKE') group by strftime('%Y-%m', BeginDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.Thefts)); }
            return DataList;
        }
        public ObservableArrayList HOOGVLIET()
        {
            string query = "select COUNT(*) as Thefts, strftime('%Y-%m', BeginDatum) as 'month_year' from Fietsdiefstal WHERE (BeginDatum between '2001-01-01' and '2016-05-07') and (Werkgebied = 'SPIJKENISSEN' or Werkgebied = 'HOOGVLIET/PERNIS' or Werkgebied = 'ROZENBURG' or Werkgebied = 'BEMBRIELLE / WESTVOORNE') group by strftime(' %Y-%m', BeginDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.Thefts)); }
            return DataList;
        }
        public ObservableArrayList Question3_2()
        {
            string query = "select COUNT(*) as FCount, strftime('%Y-%m', MutDatum) as 'month_year' from Fietstrommels WHERE (MutDatum between '2001-01-01' and '2016-05-07') and Deelgemeente = 'Centrum' group by strftime('%Y-%m', MutDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item)
            {
                DataList.Add(new ChartDataPoint(row.month_year, row.FCount));
            }

            return DataList;
        }
        public ObservableArrayList NOORD1()
        {
            string query = "select COUNT(*) as FCount, strftime('%Y-%m-%d', MutDatum) as 'month_year' from Fietstrommels WHERE (MutDatum between '2001-01-01' and '2016-05-07') and (Deelgemeente = 'Noord') group by strftime('%Y-%m', MutDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.FCount)); }
            return DataList;
        }
        public ObservableArrayList CENTRUM1()
        {
            string query1 = "SELECT COUNT(*) as FCount FROM Fietstrommels WHERE Deelgemeente = 'Centrum'";
            string query = "select COUNT(*) as FCount, strftime('%Y-%m', MutDatum) as 'month_year' from Fietstrommels WHERE (MutDatum between '2001-01-01' and '2016-05-07') and Deelgemeente = 'Centrum' group by strftime('%Y-%m', MutDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietstrommels>(query1);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.FCount)); }
            return DataList;
        }
        public ObservableArrayList FEIJNOORD1()
        {
            string query = "select COUNT(*) as FCount, strftime('%Y-%m', MutDatum) as 'month_year' from Fietstrommels WHERE (MutDatum between '2001-01-01' and '2016-05-07') and Deelgemeente = 'Feijenoord' group by strftime('%Y-%m', MutDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.FCount)); }
            return DataList;
        }
        public ObservableArrayList HILLEGERSBERG1()
        {
            string query = "select COUNT(*) as FCount, strftime('%Y-%m', MutDatum) as 'month_year' from Fietstrommels WHERE (MutDatum between '2001-01-01' and '2016-05-07') and Deelgemeente = 'Hillegersberg' group by strftime('%Y-%m', MutDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.FCount)); }
            return DataList;
        }
        public ObservableArrayList OVERSCHIE1()
        {
            string query = "select COUNT(*) as FCount, strftime('%Y-%m', MutDatum) as 'month_year' from Fietstrommels WHERE (MutDatum between '2001-01-01' and '2016-05-07') and Deelgemeente = 'Overschie' group by strftime('%Y-%m', MutDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.FCount)); }
            return DataList;
        }
        public ObservableArrayList CHARLOIS1()
        {
            string query = "select COUNT(*) as FCount, strftime('%Y-%m', MutDatum) as 'month_year' from Fietstrommels WHERE (MutDatum between '2001-01-01' and '2016-05-07') and Deelgemeente = 'Charlois' group by strftime('%Y-%m', MutDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.FCount)); }
            return DataList;
        }
        public ObservableArrayList IJSELMONDE1()
        {
            string query = "select COUNT(*) as FCount, strftime('%Y-%m', MutDatum) as 'month_year' from Fietstrommels WHERE (MutDatum between '2001-01-01' and '2016-05-07') and Deelgemeente = 'IJsselmonde' group by strftime('%Y-%m', MutDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.FCount)); }
            return DataList;
        }
        public ObservableArrayList HOOGVLIET1()
        {
            string query = "select COUNT(*) as FCount, strftime('%Y-%m', MutDatum) as 'month_year' from Fietstrommels WHERE (MutDatum between '2001-01-01' and '2016-05-07') and Deelgemeente = 'Hoogvliet' group by strftime('%Y-%m', MutDatum) order by strftime('%Y-%m', month_year)";
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item) { DataList.Add(new ChartDataPoint(row.month_year, row.FCount)); }
            return DataList;
        }

        public ObservableArrayList Question4_1()
        {
            string query = "SELECT COUNT(*) as Brands, Merk from Fietsdiefstal GROUP BY Merk ORDER BY COUNT(*) DESC LIMIT 15";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item)
            {
                DataList.Add(new ChartDataPoint(row.Merk, row.Brands));
            }

            return DataList;
        }
        public ObservableArrayList Question4_2()
        {
            string query = "SELECT COUNT(*) as Colors, Kleur from Fietsdiefstal GROUP BY Kleur ORDER BY COUNT(*) DESC LIMIT 15";
            var item = db.Query<Fietsdiefstal>(query);
            foreach (var row in item)
            {
                DataList.Add(new ChartDataPoint(row.Kleur, row.Colors));
            }

            return DataList;
        }
    }
}