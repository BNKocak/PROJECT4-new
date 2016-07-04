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
using Com.Syncfusion.Charts.Enums;

namespace sBike
{
    [Activity(Label = "Activity6")]
    public class Activity6 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //DialogFragment frag = new fraggy();
            //frag.Show(FragmentManager, frag.Tag);

            // Create your application here

            SfChart chart = new ChartFactory().Create(this, "Bar");



            // rezizing activity;;
            var layout = new LinearLayout(this) { Orientation = Android.Widget.Orientation.Vertical };

            var layoutLabel = new LinearLayout(this)
            {
                Orientation = Android.Widget.Orientation.Horizontal,
                LayoutParameters =
                    new ViewGroup.LayoutParams(500, 500)
            };


            layoutLabel.SetHorizontalGravity(GravityFlags.CenterHorizontal);

            layout.AddView(layoutLabel);
            layout.AddView(chart);

            SetContentView(layout);


        }
    }

    public class fraggy : DialogFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SfChart chart = new ChartFactory().Create(this.Activity, "Line");

            return chart;
        }
    }
}