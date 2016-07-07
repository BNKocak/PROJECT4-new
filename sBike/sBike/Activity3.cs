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
    public class Activity3 : Activity
    {
        // Create the activity
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Question3_layout);

            // Make list of buttons and activities
            List<Button> buttonlist = new List<Button>();
            List<Type> activitylist = new List<Type>();

            buttonlist.Add(FindViewById<Button>(Resource.Id.q3_button1));
            buttonlist.Add(FindViewById<Button>(Resource.Id.q3_button2));
            buttonlist.Add(FindViewById<Button>(Resource.Id.q3_button3));
            buttonlist.Add(FindViewById<Button>(Resource.Id.q3_button4));
            buttonlist.Add(FindViewById<Button>(Resource.Id.q3_button5));
            buttonlist.Add(FindViewById<Button>(Resource.Id.q3_button6));
            buttonlist.Add(FindViewById<Button>(Resource.Id.q3_button7));
            buttonlist.Add(FindViewById<Button>(Resource.Id.q3_button8));

            activitylist.Add(typeof(Activity3_1));
            activitylist.Add(typeof(Activity3_2));
            activitylist.Add(typeof(Activity3_3));
            activitylist.Add(typeof(Activity3_4));
            activitylist.Add(typeof(Activity3_5));
            activitylist.Add(typeof(Activity3_6));
            activitylist.Add(typeof(Activity3_7));
            activitylist.Add(typeof(Activity3_8));


            // foreach button connect a activity for event onClick
            foreach (Button btn in buttonlist)
            {

                btn.Click += (sender, e) =>
                {
                    var intent = new Intent(this, activitylist[buttonlist.IndexOf(btn)]);
                    StartActivity(intent);
                };
            }
        }
    }
}