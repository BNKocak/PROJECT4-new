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
    [Activity(Label = "Activity6")]
    public class Activity6 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            DialogFragment frag = new fraggy();
            frag.Show(FragmentManager, frag.Tag);

            // Create your application here
        }
    }

    public class fraggy : DialogFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SfChart chart = new IChart().Create(this.Activity, "Line");

            return chart;
        }
    }
}