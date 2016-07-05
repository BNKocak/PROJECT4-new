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
            chart.SetBackgroundColor(Color.Black);
            chart.Legend.Visibility = Visibility.Visible;
            chart.Legend.LabelStyle.TextColor = Color.White;
            chart.Title.SetTextColor(Color.White);
            ChartZoomPanBehavior zoomPanBehavior = new ChartZoomPanBehavior();
            chart.Behaviors.Add(zoomPanBehavior);

                

            if (name == "Pie")
            {
                DataModel_Question4 dataModel = new DataModel_Question4();
                PieSeries pieSeries_brands = (new PieSeries()
                {
                    DataSource = dataModel.DataList,
                    StartAngle = 45,
                    EndAngle = 405,
                    SmartLabelsEnabled = true,
                    ConnectorType = ConnectorType.Bezier,
                    DataMarkerPosition = CircularSeriesDataMarkerPosition.OutsideExtended,
                    Label = "Brands"
                });
                PieSeries pieSeries_colors = (new PieSeries()
                {
                    DataSource = dataModel.DataList,
                    StartAngle = 45,
                    EndAngle = 405,
                    SmartLabelsEnabled = true,
                    ConnectorType = ConnectorType.Bezier,
                    DataMarkerPosition = CircularSeriesDataMarkerPosition.OutsideExtended,
                    Label = "Colors"
                });
                pieSeries_brands.DataMarker.ShowLabel = true;
                pieSeries_brands.AnimationDuration = 2;
                pieSeries_brands.AnimationEnabled = true;
                chart.Series.Add(pieSeries_brands);
                chart.Series.Add(pieSeries_colors);
            }
            if (name == "Bar")
            {
                DataModel_Question1 dataModel = new DataModel_Question1();
                ColumnSeries columnSeries = (new ColumnSeries()
                {
                    DataSource = dataModel.DataList,
                    Label = "Amount of Bikecontainers"

                });
                columnSeries.DataMarker.ShowLabel = true;
                columnSeries.AnimationEnabled = true;
                columnSeries.AnimationDuration = 2;
                chart.Series.Add(columnSeries);

            }

            if (name == "GroupedBar")
            {
                DataModel_Question3_1 dataModel_1 = new DataModel_Question3_1();
                DataModel_Question3_2 dataModel_2 = new DataModel_Question3_2();
                ColumnSeries columnSeries_thefts = (new ColumnSeries()
                {
                    DataSource = dataModel_1.DataList,
                    Label = "Thefts"

                });
                ColumnSeries columnSeries_containers = (new ColumnSeries()
                {
                    DataSource = dataModel_2.DataList,
                    Label = "Containers"
                });
                columnSeries_thefts.DataMarker.ShowLabel = true;
                columnSeries_thefts.AnimationEnabled = true;
                columnSeries_thefts.AnimationDuration = 2;
                columnSeries_containers.DataMarker.ShowLabel = true;
                columnSeries_containers.AnimationEnabled = true;
                columnSeries_containers.AnimationDuration = 2;
                chart.Series.Add(columnSeries_thefts);
                chart.Series.Add(columnSeries_containers);
            }

            if (name == "Line")
            {
                DataModel_Question2 dataModel = new DataModel_Question2();
                LineSeries lineSeries = (new LineSeries()
                {
                    DataSource = dataModel.DataList,
                    Label = "Stolen Bycicles"
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