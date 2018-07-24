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
using PS.Plot.FrameBasic.Module_Common.Utils;
using Sign.Module_System.Model;
using Sign.Module_Sign.Componet;
using DevExpress.XtraEditors.Controls;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_ReadPlanCompare : DevExpress.XtraEditors.XtraUserControl,IInitialUI,ITabPageCloseCallBack
    {
        private ReadPlanCompareStatistician statistician;

        private ChartControlHelper chartHelper_ReadDays;
        private SingleDataValueSeriesBuilder databuilder_ReadDays;

        private ChartControlHelper chartHelper_Contruction;
        private SingleDataValueSeriesBuilder databuilder_Contruction;

        private ChartControlHelper chartHelper_State;
        private SingleDataValueSeriesBuilder dataBuilder_State;

        private GridControlHelper gridHelper;

        public UC_ReadPlanCompare()
        {
            InitializeComponent();
        }

        private void UC_ReadPlanCompare_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();

        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(this.GetType().Name);
        }

        public void onCreateComponet()
        {
            statistician = new ReadPlanCompareStatistician(GParam.Create());

            chartHelper_ReadDays = new ChartControlHelper(this.chart_ReadDaysCount);
            databuilder_ReadDays = new SingleDataValueSeriesBuilder();
            databuilder_ReadDays.CreateSeries("ReadDays", DevExpress.XtraCharts.ViewType.Pie);
            databuilder_ReadDays.StyleDesigner.SetPieLengedFormat("{A} - {V} 天");

            chartHelper_Contruction = new ChartControlHelper(this.chart_ReadConstruction);
            databuilder_Contruction = new SingleDataValueSeriesBuilder();
            databuilder_Contruction.CreateSeries("Construction", DevExpress.XtraCharts.ViewType.Bar);
            databuilder_Contruction.StyleDesigner.SetSeriesLengedOption(true, "{A}");
            databuilder_Contruction.StyleDesigner.SetBarSeriesEachColor(true);

            chartHelper_State = new ChartControlHelper(this.chart_ReadPlanState);
            dataBuilder_State = new SingleDataValueSeriesBuilder();
            dataBuilder_State.CreateSeries("ReadPlanState", DevExpress.XtraCharts.ViewType.Pie);
            dataBuilder_State.StyleDesigner.SetPieLengedFormat("{A} - {V} 本");

            gridHelper = new GridControlHelper(this.gridView_MonthRecord, this.gridControl_MonthRecord);
        }

        public void onInitialUI()
        {
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            statistician.QueryReadPlanDateRange(ref startDate, ref endDate);

            DateUtils  dateUtils = new DateUtils();
            dateE_ReadDayasCount_Start.DateTime = dateUtils.MonthFirstDay(DateTime.Now);
            dateE_ReadDayasCount_End.DateTime = dateUtils.MonthLastDay(DateTime.Now);
            btn_ReadDayasCount.PerformClick();

            dateE_ReadConstruction_Start.DateTime = startDate;
            dateE_ReadConstruction_End.DateTime = endDate;
            btn_ReadConstruction.PerformClick();
   
            dateE_State_Start.DateTime = startDate;
            dateE_State_End.DateTime = endDate;
            btn_ReadPlanState.PerformClick();

            cmb_year.Properties.Items.Clear();
            cmb_year.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            foreach (string item in statistician.QueryReadPlanSignYear())
            {
                cmb_year.Properties.Items.Add(item);
            }
            if(cmb_year.Properties.Items.Count > 0)
                cmb_year.SelectedIndex = 0;
        }

        private void btn_ReadDayasCount_Click(object sender, EventArgs e)
        {
            databuilder_ReadDays.ClearDataSeries();
            databuilder_ReadDays.AddDataFromTable(statistician.StatisticianReadDays(dateE_ReadDayasCount_Start.DateTime.Date, dateE_ReadDayasCount_End.DateTime.Date), 0, 1);
            chartHelper_ReadDays.ReplaceSeries(databuilder_ReadDays.DataSeries);
        }

        private void btn_ReadConstruction_Click(object sender, EventArgs e)
        {
            IList<string> states = new List<string>();
            foreach (CheckedListBoxItem item in ckeCmb_PlanState.Properties.GetItems().Where(x=>x.CheckState == CheckState.Checked))
                states.Add(item.Description);

            databuilder_Contruction.ClearDataSeries();
            databuilder_Contruction.AddDataFromTable(statistician.StatisticianReadPlanStruction(dateE_ReadConstruction_Start.DateTime,dateE_ReadConstruction_End.DateTime,states.ToArray()), 0, 1);
            chartHelper_Contruction.ReplaceSeries(databuilder_Contruction.DataSeries);
        }

        private void btn_ReadPlanState_Click(object sender, EventArgs e)
        {
            dataBuilder_State.ClearDataSeries();
            dataBuilder_State.AddDataFromDictonary(statistician.StatisticianReadPlanState(dateE_State_Start.DateTime, dateE_State_End.DateTime));
            chartHelper_State.ReplaceSeries(dataBuilder_State.DataSeries);
        }

        private void cmb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = int.Parse(cmb_year.Text);
            gridHelper.GridControl.DataSource = statistician.StatisticianFinishStateByMonth(year);
            gridHelper.SetColMaxWidth("月份",80);
        }
    }
}
