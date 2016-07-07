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
    [Activity(Label = "sBike")]
    public class Activity2 : Activity
    {
        // Create the activity
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Datamodel executes the query to get the data
            DataModel dataModel = new DataModel();

            // Create chart and set properties -> Chartfactory
            SfChart chart = new ChartFactory().Create(this, "Line", dataModel.Question2(), dataModel.Question2());

            chart.Title.Text = "Amount of thefts per month";

            CategoryAxis primaryAxis = new CategoryAxis();
            NumericalAxis secondaryAxis = new NumericalAxis();

            primaryAxis.Title.TextColor = Color.White;
            primaryAxis.Title.Text = "Date";

            secondaryAxis.Title.TextColor = Color.White;
            secondaryAxis.Title.Text = "Amount";

            chart.PrimaryAxis = primaryAxis;
            chart.SecondaryAxis = secondaryAxis;

            // Add chart to the view
            SetContentView(chart);
        }
    }
}