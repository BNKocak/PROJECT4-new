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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.Question4_layout);

            Button Brands_button = (FindViewById<Button>(Resource.Id.brands_button));
            Button Colors_button = (FindViewById<Button>(Resource.Id.colors_button));

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