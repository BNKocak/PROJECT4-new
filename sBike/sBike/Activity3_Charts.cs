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

    // All activities for charts in Question 3 are created here using ChartFactory

    [Activity()]
    public class Activity3_1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            DataModel dataModel = new DataModel();
            SfChart chart = new ChartFactory().Create(this, "GroupedBar", dataModel.CENTRUM(), dataModel.CENTRUM1());

            SetContentView(chart);
        }
    }

    [Activity()]
    public class Activity3_2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            DataModel dataModel = new DataModel();
            SfChart chart = new ChartFactory().Create(this, "GroupedBar", dataModel.NOORD(), dataModel.NOORD1());

            SetContentView(chart);
        }
    }

    [Activity()]
    public class Activity3_3 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            DataModel dataModel = new DataModel();
            SfChart chart = new ChartFactory().Create(this, "GroupedBar", dataModel.FEIJNOORD(), dataModel.FEIJNOORD1());

            SetContentView(chart);
        }
    }

    [Activity()]
    public class Activity3_4 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            DataModel dataModel = new DataModel();
            SfChart chart = new ChartFactory().Create(this, "GroupedBar", dataModel.HILLEGERSBERG(), dataModel.HILLEGERSBERG1());

            SetContentView(chart);
        }
    }

    [Activity()]
    public class Activity3_5 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            DataModel dataModel = new DataModel();
            SfChart chart = new ChartFactory().Create(this, "GroupedBar", dataModel.OVERSCHIE(), dataModel.OVERSCHIE1());

            SetContentView(chart);
        }
    }

    [Activity()]
    public class Activity3_6 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            DataModel dataModel = new DataModel();
            SfChart chart = new ChartFactory().Create(this, "GroupedBar", dataModel.CHARLOIS(), dataModel.CHARLOIS1());

            SetContentView(chart);
        }
    }

    [Activity()]
    public class Activity3_7 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            DataModel dataModel = new DataModel();
            SfChart chart = new ChartFactory().Create(this, "GroupedBar", dataModel.IJSELMONDE(), dataModel.IJSELMONDE1());

            SetContentView(chart);
        }
    }

    [Activity()]
    public class Activity3_8 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            DataModel dataModel = new DataModel();
            SfChart chart = new ChartFactory().Create(this, "GroupedBar", dataModel.HOOGVLIET(), dataModel.HOOGVLIET1());

            SetContentView(chart);
        }
    }
}