using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using Sign.Module_System.Model;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools.ChartHelper2;
using Sign.Module_Sign.Controller;
using Sign.Module_Sign.Componet.Command;
using DevExpress.XtraCharts;
using DevExpress.Utils;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_GYMCompare : DevExpress.XtraEditors.XtraUserControl, IInitialUI, ITabPageCloseCallBack
    {
        private ChartControlHelper baseChartHelper;
        private ChartControlHelper appChartHelper;
        private ChartControlHelper dateChartHelper;
        private ChartControlHelper sumChartHelper;

        private SingleDataValueSeriesBuilder baseDatabuilder;
        private IList<SingleDataValueSeriesBuilder> appDataBuilder;
        private SingleDataValueSeriesBuilder dateCountDataBuilder;
        private SingleDataValueSeriesBuilder dateSumDataBuilder;
        
        private GYMBaseManageController controller;

        private DateTime startDate, endDate;

        public UC_GYMCompare()
        {
            InitializeComponent();
        }

        private void UC_GYMCompare_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            controller = new GYMBaseManageController();
            controller.QueryEntryDataRange(out startDate, out endDate);

            baseChartHelper = new ChartControlHelper(this.chartControl1);
            baseDatabuilder = new SingleDataValueSeriesBuilder();
            baseDatabuilder.CreateSeries("跑步训练量", DevExpress.XtraCharts.ViewType.Line);
            
            appChartHelper = new ChartControlHelper(chartControl2);
            appDataBuilder = new List<SingleDataValueSeriesBuilder>();
            foreach (var item in new GYMCatalogManageController().TravleAllEntities())
            {
                SingleDataValueSeriesBuilder temp = new SingleDataValueSeriesBuilder();
                temp.CreateSeries(item.Name, DevExpress.XtraCharts.ViewType.Line);
                appDataBuilder.Add(temp);
            }

            dateChartHelper = new ChartControlHelper(this.chartControl3); 
            dateCountDataBuilder = new SingleDataValueSeriesBuilder();
            dateCountDataBuilder.CreateSeries("temp", DevExpress.XtraCharts.ViewType.Pie);
            dateCountDataBuilder.StyleDesigner.SetPieLengedFormat("{A}:{V:n0}天");

            sumChartHelper = new ChartControlHelper(this.chartControl4);
            dateSumDataBuilder = new SingleDataValueSeriesBuilder();
            dateSumDataBuilder.CreateSeries("temp", DevExpress.XtraCharts.ViewType.Bar);
            dateSumDataBuilder.StyleDesigner.SetPieLengedFormat("{A}");
            dateSumDataBuilder.StyleDesigner.SetBarSeriesEachColor(true);
        }

        public void onInitialUI()
        {
            dateEdit_Start.DateTime = startDate;
            dateEdit_End.DateTime = endDate;
            //有氧训练图
            baseDatabuilder.ClearDataSeries();
            foreach (var item in controller.TraveleEntriesByDateRange(startDate,endDate))
            {
                baseDatabuilder.AddData(DateTime.Parse(item.Date), item.Calorie);
            }
            baseDatabuilder.StyleDesigner.SetLineSeriesStyle(DevExpress.XtraCharts.DashStyle.Solid, 5, Color.LightBlue);
            baseDatabuilder.StyleDesigner.SetLineSeriesMarkerStyle(DevExpress.XtraCharts.MarkerKind.Circle, 6, Color.LightGreen);
            baseChartHelper.ReplaceSeries(baseDatabuilder.DataSeries);
            baseChartHelper.SetYaxisRange(baseDatabuilder.MinValue, baseDatabuilder.MaxValue, 10);
            //器械训练图
            GYMAPPARATUSStatistician statistician = new GYMAPPARATUSStatistician(GParam.Create());
            foreach (var item in new GYMCatalogManageController().TravleAllEntities())
            {
                SingleDataValueSeriesBuilder tempBuilder = appDataBuilder.First(x => x.DataSeries.Name.Equals(item.Name));
                tempBuilder.ClearDataSeries();
                foreach(DataRow row in statistician.StatisticDateRangeTypeTotal(item.ID,startDate,endDate).Rows)
                   tempBuilder.AddData(DateTime.Parse(row[0].ToString()), double.Parse(row[1].ToString()));
                appChartHelper.ReplaceSeries(tempBuilder.DataSeries);
            }
            //锻炼日期数
            dateCountDataBuilder.ClearDataSeries();
            int[] countResult = statistician.StatisticGYMRecordCount(startDate, endDate);
            tv_StatisiticDay.Text = ""+countResult[0];
            tv_ExericeDays.Text = "" + countResult[1];
            dateCountDataBuilder.AddData("锻炼天数",countResult[1]);
            dateCountDataBuilder.AddData("未锻炼天数", countResult[2]);
            dateChartHelper.ReplaceSeries(dateCountDataBuilder.DataSeries);
            //累计训练量
            dateSumDataBuilder.ClearDataSeries();
            dateSumDataBuilder.AddDataFromTable(statistician.StatisticGYMDateRangeCatalogSum(startDate, endDate), 0, 1);
            sumChartHelper.ReplaceSeries(dateSumDataBuilder.DataSeries);
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(this.GetType().Name);
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            startDate = dateEdit_Start.DateTime.Date;
            endDate = dateEdit_End.DateTime.Date;
            onInitialUI();
        }

        //private void onTestBar()
        //{
        //    // Create two bubble series.
        //    Series series1 = new Series("Series 1", ViewType.Bar);
        //    series1.Points.Add(new SeriesPoint("A", Math.Log10(20)));
        //    series1.Points.Add(new SeriesPoint("B", Math.Log10(30)));
        //    series1.Points.Add(new SeriesPoint("C", Math.Log10(10)));
        //    series1.Points.Add(new SeriesPoint("D", Math.Log10(5)));
        //    series1.Points.Add(new SeriesPoint("E", Math.Log10(10000)));
        //    series1.ArgumentScaleType = ScaleType.Qualitative;
        //    series1.LegendTextPattern = "{A}";
        //    ((BarSeriesView)series1.View).ColorEach = true;
        //    this.chartControl4.Series.Add(series1);
        //}


        //private void onTestBubble()
        //{
        //    // Create two bubble series.
        //    Series series1 = new Series("Series 1", ViewType.Bubble);

        //    // Add points to them.
        //    series1.Points.Add(new SeriesPoint("A", 0, 20));
        //    series1.Points.Add(new SeriesPoint("B", 0, 30));
        //    series1.Points.Add(new SeriesPoint("C", 0, 10));
        //    series1.Points.Add(new SeriesPoint("D", 0, 5));
        //    series1.Points.Add(new SeriesPoint("E", 0, 10000));


        //    // Add both series to the chart.
        //    this.chartControl4.Series.Add(series1);

        //    // Set the numerical argument scale types for the series,
        //    // as it is qualitative, by default.
        //    series1.ArgumentScaleType = ScaleType.Qualitative;

        //    // Access the view-type-specific options of the series.
        //    ((BubbleSeriesView)series1.View).AutoSize = true;
        //    //((BubbleSeriesView)series1.View).MaxSize = 100;
        //    //((BubbleSeriesView)series1.View).MinSize = 1;
        //    ((BubbleSeriesView)series1.View).BubbleMarkerOptions.Kind = MarkerKind.Hexagon;

        //    // Access the type-specific options of the diagram.
        //    //((XYDiagram)chartControl4.Diagram).Rotated = true;
        //}
    }
}
