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
    public class Activity4 : Activity
    {
        // Create the activity
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Set the view to layout
            SetContentView(Resource.Layout.Question4_layout);

            // Create the buttons by loading resource
            Button Brands_button = (FindViewById<Button>(Resource.Id.brands_button));
            Button Colors_button = (FindViewById<Button>(Resource.Id.colors_button));

            // Connect buttons to an activity onClick
            Brands_button.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity4_1));
                StartActivity(intent);
            };

            Colors_button.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity4_2));
                StartActivity(intent);
            };
        }
    }
}