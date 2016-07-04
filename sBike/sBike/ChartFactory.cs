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

namespace sBike
{
    class ChartFactory
    {
        public SfChart Create(Activity source, string name)
        {
            SfChart chart = new SfChart(source);
            CategoryAxis primaryAxis = new CategoryAxis();

            chart.SetBackgroundColor(Color.Black);
            primaryAxis.Title.Text = "Deelgemeente";
            primaryAxis.Title.TextColor = Color.White;
            chart.PrimaryAxis = primaryAxis;
            NumericalAxis secondaryAxis = new NumericalAxis();
            secondaryAxis.Title.Text = "Aantal fietstrommels";
            secondaryAxis.Title.TextColor = Color.White;
            chart.SecondaryAxis = secondaryAxis;
            chart.Legend.Visibility = Visibility.Visible;
            chart.Legend.LabelStyle.TextColor = Color.White;
            chart.Title.Text = "Top 5 amount of thefts per neighbourhood";
            chart.Title.SetTextColor(Color.White);
            ChartZoomPanBehavior zoomPanBehavior = new ChartZoomPanBehavior();
            chart.Behaviors.Add(zoomPanBehavior);
            chart.Legend.ToggleSeriesVisibility = true;

            DataModel dataModel = new DataModel();

            if (name == "Pie")
            {
                PieSeries pieSeries = (new PieSeries()
                {
                    DataSource = dataModel.HighTemperature,
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
                ColumnSeries columnSeries = (new ColumnSeries()
                {
                    DataSource = dataModel.HighTemperature,
                    Label = "Thefts"

                });
                columnSeries.DataMarker.ShowLabel = true;
                columnSeries.AnimationEnabled = true;
                columnSeries.AnimationDuration = 2;
                chart.Series.Add(columnSeries);

            }
            if (name == "Line")
            {
                LineSeries lineSeries = (new LineSeries()
                {
                    DataSource = dataModel.HighTemperature,
                    Label = "Test"
                });
                lineSeries.DataMarker.ShowLabel = true;
                lineSeries.AnimationEnabled = true;
                lineSeries.AnimationDuration = 2;
                chart.Series.Add(lineSeries);
            }


            return chart;
        }
    }
}