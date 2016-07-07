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
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Datamodel executes the query to get the data
            DataModel dataModel = new DataModel();

            // Create chart and set properties -> Chartfactory
            SfChart chart = new ChartFactory().Create(this, "Bar", dataModel.Question1(), dataModel.Question1());
            chart.Title.Text = "Top 5 amount of bikecontainers per neighbourhood";

            CategoryAxis primaryAxis = new CategoryAxis();
            NumericalAxis secondaryAxis = new NumericalAxis();

            primaryAxis.Title.TextColor = Color.White;
            primaryAxis.Title.Text = "Neighbourhood";

            secondaryAxis.Title.TextColor = Color.White;
            secondaryAxis.Title.Text = "Bikecontainers";

            chart.PrimaryAxis = primaryAxis;
            chart.SecondaryAxis = secondaryAxis;

            SetContentView(chart);
        }
    }
    
}