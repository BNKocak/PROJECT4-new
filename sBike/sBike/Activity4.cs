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
    [Activity(Label = "Activity4")]
    public class Activity4 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SfChart chart = new ChartFactory().Create(this, "Pie");

            SetContentView(chart);
        }
    }
}