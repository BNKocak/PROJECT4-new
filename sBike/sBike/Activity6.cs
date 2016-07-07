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
using Android.Util;
using Java.Util;
using Android.Provider;

namespace sBike
{
    [Activity(Label = "sBike")]
    public class Activity6 : Activity
    {
        // Create the activity.

        TextView _dateDisplay;
        Button _dateSelectButton;
        Button _addReminderButton;
        DateTime tempfrag;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Question7_layout);

            // Load buttons and events.
            _addReminderButton = FindViewById<Button>(Resource.Id.add_reminder);
            _dateDisplay = FindViewById<TextView>(Resource.Id.date_display);
            _dateSelectButton = FindViewById<Button>(Resource.Id.date_select_button);
            _dateSelectButton.Click += (sender, eventArgs) =>
            {
                DatePickerFragment frag = DatePickerFragment.NewInstance(delegate (DateTime time)
                {
                    _dateDisplay.Text = time.ToLongDateString();
                    tempfrag = time;
                });
                frag.Show(FragmentManager, DatePickerFragment.TAG);
            };
            _addReminderButton.Click += (sender, eventArgs) =>
            {
                InitAddEvent();
                Toast.MakeText(this, "Reminder added at " + _dateDisplay.Text, ToastLength.Short).Show();
            };
        }


        void InitAddEvent()
        {
            var addSampleEvent = FindViewById<Button>(Resource.Id.add_reminder);

            
            // Create Event code.
            ContentValues eventValues = new ContentValues();
            eventValues.Put(CalendarContract.Events.InterfaceConsts.CalendarId, 1);
            eventValues.Put(CalendarContract.Events.InterfaceConsts.Title, "Pick up bike");
            eventValues.Put(CalendarContract.Events.InterfaceConsts.Description, "Don't forget to pick up my bike");
            eventValues.Put(CalendarContract.Events.InterfaceConsts.Dtstart, GetDateTimeMS(tempfrag.Year, tempfrag.Month, tempfrag.Day, tempfrag.Hour, tempfrag.Minute));
            eventValues.Put(CalendarContract.Events.InterfaceConsts.Dtend, GetDateTimeMS(tempfrag.Year, tempfrag.Month, tempfrag.Day, tempfrag.Hour, tempfrag.Minute));

            eventValues.Put(CalendarContract.Events.InterfaceConsts.EventTimezone, "UTC");
            eventValues.Put(CalendarContract.Events.InterfaceConsts.EventEndTimezone, "UTC");



            var uri = ContentResolver.Insert(CalendarContract.Events.ContentUri, eventValues);

            // Debugging purposes.
            Console.WriteLine("Uri for new event: {0}", uri);
        }


        // Used because it is necessary.
        long GetDateTimeMS(int yr, int month, int day, int hr, int min)
        {
            Calendar c = Calendar.GetInstance(Java.Util.TimeZone.Default);

            c.Set(Calendar.DayOfMonth, day);
            c.Set(Calendar.HourOfDay, hr);
            c.Set(Calendar.Minute, min);
            c.Set(Calendar.Month, month - 1);
            c.Set(Calendar.Year, yr);

            return c.TimeInMillis;
        }
    }


    public class DatePickerFragment : DialogFragment, DatePickerDialog.IOnDateSetListener
    {
        // Setting Tag on fragment in order to call.
        public static readonly string TAG = "X:" + typeof(DatePickerFragment).Name.ToUpper();
        Action<DateTime> _dateSelectedHandler = delegate { };
        public DateTime date;

        public void OnDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth)
        {
            // Note: monthOfYear is a value between 0 and 11, not 1 and 12!
            // Set date to selectedDate in order to use it in function above for saving event.
            DateTime selectedDate = new DateTime(year, monthOfYear + 1, dayOfMonth);
            date = selectedDate;
            Log.Debug(TAG, selectedDate.ToLongDateString());
            
            _dateSelectedHandler(selectedDate);
            
        }

        public static DatePickerFragment NewInstance(Action<DateTime> onDateSelected)
        {
            DatePickerFragment frag = new DatePickerFragment();
            frag._dateSelectedHandler = onDateSelected;
            
            return frag;
        }

        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            DateTime currently = DateTime.Now;
            DatePickerDialog dialog = new DatePickerDialog(Activity, this, currently.Year, currently.Month - 1,
                                                           currently.Day);
            return dialog;
        }
    }
}