using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using sBike;
using Com.Syncfusion.Charts;

namespace Phoneword
{
    [Activity(Label = "sBike", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Our code will go here
            //EditText phoneNumberText = FindViewById<EditText>(Resource.Id.PhoneNumberText);
            Button button1 = FindViewById<Button>(Resource.Id.Vraag1);
            Button button2 = FindViewById<Button>(Resource.Id.Vraag2);
            Button button3 = FindViewById<Button>(Resource.Id.Vraag3);
            Button button4 = FindViewById<Button>(Resource.Id.Vraag4);
            Button button5 = FindViewById<Button>(Resource.Id.Vraag5);
            Button button6 = FindViewById<Button>(Resource.Id.Vraag6);
            Button button7 = FindViewById<Button>(Resource.Id.Vraag7);
            Button btnDatabase = FindViewById<Button>(Resource.Id.btnDatabase);

            button1.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity1));
                StartActivity(intent);
            };

            button2.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity2));
                StartActivity(intent);
            };

            button3.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity3));
                StartActivity(intent);
            };

            button4.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity4));
                StartActivity(intent);
            };

            button5.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity5));
                StartActivity(intent);
            };

            button6.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity6));
                StartActivity(intent);
            };

            button7.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Activity7));
                StartActivity(intent);
            };

            btnDatabase.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(database_Activity));
                StartActivity(intent);
            };

            //// Disable the "Call" button
            //callButton.Enabled = false;

            //// Add code to translate number
            //string translatedNumber = string.Empty;

            //translateButton.Click += (object sender, EventArgs e) =>
            //{
            //    // Translate user's alphanumeric phone number to numeric
            //    translatedNumber = Core.PhonewordTranslator.ToNumber(phoneNumberText.Text);
            //    if (String.IsNullOrWhiteSpace(translatedNumber))
            //    {
            //        callButton.Text = "Call";
            //        callButton.Enabled = false;
            //    }
            //    else
            //    {
            //        callButton.Text = "Call " + translatedNumber;
            //        callButton.Enabled = true;
            //    }
            //};
        }
    }
}