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
        public ObservableArrayList HighTemperature;

        public DataModel()
        {
            HighTemperature = new ObservableArrayList();

            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ormdemo.db3");
            var db = new SQLiteConnection(dbPath);
            string query = "SELECT COUNT(*),Deelgemeente from Fietstrommels GROUP BY Deelgemeente ORDER BY COUNT(*) DESC LIMIT 5";
            int i = 0;
            int[] FCount = { 222, 168, 88, 78, 56 };
            var item = db.Query<Fietstrommels>(query);
            foreach (var row in item)
            {
                HighTemperature.Add(new ChartDataPoint(row.Deelgemeente, FCount[i]));
                i++;
            }
        }
    }
}