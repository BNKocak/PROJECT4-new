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
using Com.Syncfusion.Charts.Enums;
using Android.Graphics;
using Java.Lang;

namespace sBike
{
    class ChartFactory
    {
        public SfChart Create(Activity source, string name, ObservableArrayList dataModel, ObservableArrayList dataModel_2)
        {
            SfChart chart = new SfChart(source);
            chart.SetBackgroundColor(Color.Black);
            chart.Legend.Visibility = Visibility.Visible;
            chart.Legend.LabelStyle.TextColor = Color.White;
            chart.Title.SetTextColor(Color.White);
            ChartZoomPanBehavior zoomPanBehavior = new ChartZoomPanBehavior();
            chart.Behaviors.Add(zoomPanBehavior);
        

            if (name == "Pie")
            {
                PieSeries pieSeries = (new PieSeries()
                {
                    DataSource = dataModel,
                    StartAngle = 45,
                    EndAngle = 405,
                    SmartLabelsEnabled = true,
                    ConnectorType = ConnectorType.Bezier,
                    DataMarkerPosition = CircularSeriesDataMarkerPosition.OutsideExtended,
                });
                
                pieSeries.DataMarker.ShowLabel = true;
                pieSeries.AnimationDuration = 2;
                pieSeries.AnimationEnabled = true;
                chart.Series.Add(pieSeries);
            }
            if (name == "Bar")
            {
                var colors = new List<Integer>();
                colors.Add(new Integer(Color.Red));
                colors.Add(new Integer(Color.Cyan));
                colors.Add(new Integer(Color.Blue));
                colors.Add(new Integer(Color.Green));
                colors.Add(new Integer(Color.Yellow));

                

                ColumnSeries columnSeries = (new ColumnSeries()
                {
                    DataSource = dataModel,
                    Label = "Amount of bike containers"

                });
                columnSeries.DataMarker.ShowLabel = true;
                columnSeries.AnimationEnabled = true;
                columnSeries.AnimationDuration = 2;
                columnSeries.ColorModel.ColorPalette = ChartColorPalette.Custom;
                columnSeries.ColorModel.CustomColors = colors;
                chart.Series.Add(columnSeries);
                chart.Legend.Visibility = null;

            }

            if (name == "GroupedBar")
            {

                var colors = new List<Integer>();
                colors.Add(new Integer(Color.Red));
                //colors.Add(new Integer(Color.Cyan));

                ColumnSeries columnSeries_1 = (new ColumnSeries()
                {
                    DataSource = dataModel,
                    Label = "Thefts"

                });
                ColumnSeries columnSeries_2 = (new ColumnSeries()
                {
                    DataSource = dataModel_2,
                    Label = "Containers"
                });
                columnSeries_1.DataMarker.ShowLabel = true;
                columnSeries_1.AnimationEnabled = true;
                columnSeries_1.AnimationDuration = 2;
                columnSeries_2.DataMarker.ShowLabel = true;
                columnSeries_2.AnimationEnabled = true;
                columnSeries_2.AnimationDuration = 2;
                columnSeries_2.ColorModel.ColorPalette = ChartColorPalette.Custom;
                columnSeries_2.ColorModel.CustomColors = colors;

                chart.Title.Text = "Amount of thefts and bike containers per month";

                CategoryAxis primaryAxis = new CategoryAxis();
                NumericalAxis secondaryAxis = new NumericalAxis();
                primaryAxis.Title.TextColor = Color.White;
                primaryAxis.Title.Text = "Date (2011-2013)";
                secondaryAxis.Title.TextColor = Color.White;
                secondaryAxis.Title.Text = "Amount";

                chart.PrimaryAxis = primaryAxis;
                chart.SecondaryAxis = secondaryAxis;
                chart.Series.Add(columnSeries_1);
                chart.Series.Add(columnSeries_2);
            }

            if (name == "Line")
            {
                LineSeries lineSeries = (new LineSeries()
                {
                    DataSource = dataModel,
                    Label = "Stolen bicycles"
                });
                lineSeries.DataMarker.ShowLabel = true;
                lineSeries.DataMarker.LabelStyle.TextColor = Color.Black;
                lineSeries.AnimationEnabled = true;
                lineSeries.AnimationDuration = 2;
                chart.Series.Add(lineSeries);
            }


            return chart;
        }
    }
}