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
    [Activity()]
    public class Activity3_1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            DataModel dataModel = new DataModel();
            SfChart chart = new ChartFactory().Create(this, "GroupedBar", dataModel.CENTRUM(), dataModel.CENTRUM1());

            chart.Title.Text = "Amount of Thefts and Bikecontainers per month";

            CategoryAxis primaryAxis = new CategoryAxis();
            NumericalAxis secondaryAxis = new NumericalAxis();

            primaryAxis.Title.TextColor = Color.White;
            primaryAxis.Title.Text = "Date";

            secondaryAxis.Title.TextColor = Color.White;
            secondaryAxis.Title.Text = "Amount";

            chart.PrimaryAxis = primaryAxis;
            chart.SecondaryAxis = secondaryAxis;

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

            chart.Title.Text = "Amount of Thefts and Bikecontainers per month";

            CategoryAxis primaryAxis = new CategoryAxis();
            NumericalAxis secondaryAxis = new NumericalAxis();

            primaryAxis.Title.TextColor = Color.White;
            primaryAxis.Title.Text = "Date";

            secondaryAxis.Title.TextColor = Color.White;
            secondaryAxis.Title.Text = "Amount";

            chart.PrimaryAxis = primaryAxis;
            chart.SecondaryAxis = secondaryAxis;

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

            chart.Title.Text = "Amount of Thefts and Bikecontainers per month";

            CategoryAxis primaryAxis = new CategoryAxis();
            NumericalAxis secondaryAxis = new NumericalAxis();

            primaryAxis.Title.TextColor = Color.White;
            primaryAxis.Title.Text = "Date";

            secondaryAxis.Title.TextColor = Color.White;
            secondaryAxis.Title.Text = "Amount";

            chart.PrimaryAxis = primaryAxis;
            chart.SecondaryAxis = secondaryAxis;

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

            chart.Title.Text = "Amount of Thefts and Bikecontainers per month";

            CategoryAxis primaryAxis = new CategoryAxis();
            NumericalAxis secondaryAxis = new NumericalAxis();

            primaryAxis.Title.TextColor = Color.White;
            primaryAxis.Title.Text = "Date";

            secondaryAxis.Title.TextColor = Color.White;
            secondaryAxis.Title.Text = "Amount";

            chart.PrimaryAxis = primaryAxis;
            chart.SecondaryAxis = secondaryAxis;

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

            chart.Title.Text = "Amount of Thefts and Bikecontainers per month";

            CategoryAxis primaryAxis = new CategoryAxis();
            NumericalAxis secondaryAxis = new NumericalAxis();

            primaryAxis.Title.TextColor = Color.White;
            primaryAxis.Title.Text = "Date";

            secondaryAxis.Title.TextColor = Color.White;
            secondaryAxis.Title.Text = "Amount";

            chart.PrimaryAxis = primaryAxis;
            chart.SecondaryAxis = secondaryAxis;

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

            chart.Title.Text = "Amount of Thefts and Bikecontainers per month";

            CategoryAxis primaryAxis = new CategoryAxis();
            NumericalAxis secondaryAxis = new NumericalAxis();

            primaryAxis.Title.TextColor = Color.White;
            primaryAxis.Title.Text = "Date";

            secondaryAxis.Title.TextColor = Color.White;
            secondaryAxis.Title.Text = "Amount";

            chart.PrimaryAxis = primaryAxis;
            chart.SecondaryAxis = secondaryAxis;

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

            chart.Title.Text = "Amount of Thefts and Bikecontainers per month";

            CategoryAxis primaryAxis = new CategoryAxis();
            NumericalAxis secondaryAxis = new NumericalAxis();

            primaryAxis.Title.TextColor = Color.White;
            primaryAxis.Title.Text = "Date";

            secondaryAxis.Title.TextColor = Color.White;
            secondaryAxis.Title.Text = "Amount";

            chart.PrimaryAxis = primaryAxis;
            chart.SecondaryAxis = secondaryAxis;

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

            chart.Title.Text = "Amount of Thefts and Bikecontainers per month";

            CategoryAxis primaryAxis = new CategoryAxis();
            NumericalAxis secondaryAxis = new NumericalAxis();

            primaryAxis.Title.TextColor = Color.White;
            primaryAxis.Title.Text = "Date";

            secondaryAxis.Title.TextColor = Color.White;
            secondaryAxis.Title.Text = "Amount";

            chart.PrimaryAxis = primaryAxis;
            chart.SecondaryAxis = secondaryAxis;

            SetContentView(chart);
        }
    }
}