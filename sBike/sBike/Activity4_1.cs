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
    public class Activity4_1 : Activity
    {
        // Create the activity.
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Datamodel executes the query to get the data.
            DataModel dataModel = new DataModel();

            // Create chart and set properties -> Chartfactory
            SfChart chart = new ChartFactory().Create(this, "Pie", dataModel.Question4_1(), dataModel.Question4_1());
            chart.Title.Text = "Top 10 stolen bike brands";

            CategoryAxis primaryAxis = new CategoryAxis();
            NumericalAxis secondaryAxis = new NumericalAxis();

            primaryAxis.Title.TextColor = Color.White;
            secondaryAxis.Title.TextColor = Color.White;

            chart.PrimaryAxis = primaryAxis;
            chart.SecondaryAxis = secondaryAxis;

            // Add chart to the view.
            SetContentView(chart);
        }
    }
}