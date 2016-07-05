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
    [Activity(Label = "Activity2")]
    public class Activity2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            DataModel dataModel = new DataModel();
            SfChart chart = new ChartFactory().Create(this, "Line", dataModel.Question2(), dataModel.Question2());

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