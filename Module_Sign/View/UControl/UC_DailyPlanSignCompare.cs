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
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools.ChartHelper2;
using Sign.Module_Sign.Componet;
using Sign.Module_System.Model;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_DailyPlanSignCompare : DevExpress.XtraEditors.XtraUserControl, IInitialUI, ITabPageCloseCallBack
    {

        private ChartControlHelper chartHelper_Month;
        private SingleDataValueSeriesBuilder dataBuilder_Month;

        private ChartControlHelper chartHelper_Year;
        private MulitSingleDataValueSeriesBuilder dataBuilder_Year;

        private DailyPlanSignStatistician statistician;

        public UC_DailyPlanSignCompare()
        {
            InitializeComponent();
        }

        private void UC_DailyPlanSignCompare_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            statistician = new DailyPlanSignStatistician(GParam.Create());

            chartHelper_Month = new ChartControlHelper(chartControl_Month);
            dataBuilder_Month = new SingleDataValueSeriesBuilder();
            dataBuilder_Month.CreateSeries("Result", DevExpress.XtraCharts.ViewType.Bar);
            dataBuilder_Month.StyleDesigner.SetPieLengedFormat("{A}");
            dataBuilder_Month.StyleDesigner.SetBarSeriesEachColor(true);

            chartHelper_Year = new ChartControlHelper(chartControl_Year);
            dataBuilder_Year = new MulitSingleDataValueSeriesBuilder();
            dataBuilder_Year.CreateSeriesDict(DevExpress.XtraCharts.ViewType.Line);
        }

        public void onInitialUI()
        {
            cmb_MothDate.Properties.Items.Clear();
            foreach (string monthDate in statistician.QueryDailyPlanMonthDate())
            {
                cmb_MothDate.Properties.Items.Add(monthDate);
            }
            if (cmb_MothDate.Properties.Items.Count > 0)
                cmb_MothDate.SelectedIndex = 0;

            cmb_YearDate.Properties.Items.Clear();
            foreach (string monthDate in statistician.QueryDailyPlanYearDate())
            {
                cmb_YearDate.Properties.Items.Add(monthDate);
            }
            if (cmb_YearDate.Properties.Items.Count > 0)
                cmb_YearDate.SelectedIndex = 0;
        }

        private void cmb_MothDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MonthDate = cmb_MothDate.Text;
            DateTime startDate = DateTime.Parse(MonthDate + "-01");
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            dataBuilder_Month.ClearDataSeries();

            dataBuilder_Month.AddDataFromTable(statistician.StatisticDailyPlanCount(startDate, endDate), 0, 1);
            chartHelper_Month.ReplaceSeries(dataBuilder_Month.DataSeries);
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(this.GetType().Name);
        }

        private void cmb_YearDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = cmb_YearDate.Text;

            dataBuilder_Year.ClearAllSeriesPoint();

            dataBuilder_Year.AddSereisFromDictionary(statistician.StatisticDailyPlanYearMonthCount(year));
            foreach (var item in dataBuilder_Year.SeriesDict)
                chartHelper_Year.AddSeries(item.Value);
        }
    }
}
