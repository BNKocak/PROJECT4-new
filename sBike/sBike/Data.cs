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
using Com.Syncfusion.Charts;

namespace sBike
{
    public class DataModel
    {
        public ObservableArrayList HighTemperature;

        public DataModel()
        {
            HighTemperature = new ObservableArrayList();
            HighTemperature.Add(new ChartDataPoint("Jan", 42));
            HighTemperature.Add(new ChartDataPoint("Feb", 44));
            HighTemperature.Add(new ChartDataPoint("Mar", 53));
            HighTemperature.Add(new ChartDataPoint("Apr", 64));
            HighTemperature.Add(new ChartDataPoint("May", 75));
            HighTemperature.Add(new ChartDataPoint("Jun", 83));
            HighTemperature.Add(new ChartDataPoint("Jul", 87));
            HighTemperature.Add(new ChartDataPoint("Aug", 84));
            HighTemperature.Add(new ChartDataPoint("Sep", 78));
            HighTemperature.Add(new ChartDataPoint("Oct", 67));
            HighTemperature.Add(new ChartDataPoint("Nov", 55));
            HighTemperature.Add(new ChartDataPoint("Dec", 45));
        }
    }
}