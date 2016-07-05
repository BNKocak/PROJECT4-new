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
using Android.Graphics;

namespace sBike
{
    [Activity()]
    public class Activity4_2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            DataModel dataModel = new DataModel();
            SfChart chart = new ChartFactory().Create(this, "Pie", dataModel.Question4_2(), dataModel.Question4_2());

            chart.Title.Text = "Top 5 amount of thefts per neighbourhood";

            CategoryAxis primaryAxis = new CategoryAxis();
            NumericalAxis secondaryAxis = new NumericalAxis();

            primaryAxis.Title.TextColor = Color.White;
            primaryAxis.Title.Text = "Deelgemeente";

            secondaryAxis.Title.TextColor = Color.White;
            secondaryAxis.Title.Text = "Aantal fietstrommels";

            chart.PrimaryAxis = primaryAxis;
            chart.SecondaryAxis = secondaryAxis;

            SetContentView(chart);
        }
    }
}