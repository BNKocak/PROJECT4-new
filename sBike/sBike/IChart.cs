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
using Com.Syncfusion.Charts.Enums;
using Android.Graphics;

namespace sBike
{
    class IChart
    {
        public SfChart Create(Activity source, string name)
        {
            SfChart chart = new SfChart(source);
            CategoryAxis primaryAxis = new CategoryAxis();

            primaryAxis.Title.Text = "Deelgemeente";
            chart.PrimaryAxis = primaryAxis;
            NumericalAxis secondaryAxis = new NumericalAxis();
            secondaryAxis.Title.Text = "Aantal fietstrommels";
            chart.SecondaryAxis = secondaryAxis;
            chart.Legend.Visibility = Visibility.Visible;
            chart.Legend.LabelStyle.TextColor = Color.White;



            DataModel dataModel = new DataModel();

            if (name == "Pie")
            {
                chart.Series.Add(new PieSeries()
                {
                    DataSource = dataModel.HighTemperature
                });
            }
            if (name == "Bar")
            {
                chart.Series.Add(new BarSeries()
                {
                    DataSource = dataModel.HighTemperature
                });
            }
            if (name == "Line")
            {
                chart.Series.Add(new LineSeries()
                {
                    DataSource = dataModel.HighTemperature
                });
            }
            

            return chart;
        }
    }
}