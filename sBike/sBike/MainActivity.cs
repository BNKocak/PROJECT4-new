using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using sBike;
using Com.Syncfusion.Charts;
using System.Collections.Generic;
using System.Globalization;

namespace Phoneword
{
    [Activity(Label = "sBike", MainLauncher = true)]
    public class MainActivity : Activity
    {
        // Create the activity.
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource.
            SetContentView(Resource.Layout.Main);

            // Make list of buttons and activities.
            List<Button> buttonlist = new List<Button>();
            List<Type> activitylist = new List<Type>();

            buttonlist.Add(FindViewById<Button>(Resource.Id.Vraag1));
            buttonlist.Add(FindViewById<Button>(Resource.Id.Vraag2));
            buttonlist.Add(FindViewById<Button>(Resource.Id.Vraag3));
            buttonlist.Add(FindViewById<Button>(Resource.Id.Vraag4));
            buttonlist.Add(FindViewById<Button>(Resource.Id.Vraag5));
            buttonlist.Add(FindViewById<Button>(Resource.Id.Vraag7));

            activitylist.Add(typeof(Activity1));
            activitylist.Add(typeof(Activity2));
            activitylist.Add(typeof(Activity3));
            activitylist.Add(typeof(Activity4));
            activitylist.Add(typeof(Activity5));
            activitylist.Add(typeof(Activity6));

            DBRepository dbr = new DBRepository();
            dbr.deleteData();
            dbr.CreateDB();
            dbr.CreateTable();
            dbr.AddRecord(this);

            // foreach button connect a activity for event onClick.
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