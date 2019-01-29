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
using Sign.Module_Sign.Componet;
using PS.Plot.FrameBasic.Module_Common.Utils;
using Sign.Module_Sign.Controller;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools.ChartHelper2;
using Sign.Module_Sign.Model;
using DevExpress.XtraScheduler;
using Sign.Module_Sign.Componet.Adapter;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_DailyPlanSignStatistician : DevExpress.XtraEditors.XtraUserControl, IInitialUI, ITabPageCloseCallBack 
    {
        private DailyPlanSignStatistician statistician;
        private DailyPlanSignManageController controller;

        private ChartControlHelper chartHelper_Precent;
        private SingleDataValueSeriesBuilder dataBuilder_Precent;

        private ChartControlHelper chartHelper_State;
        private SingleDataValueSeriesBuilder dataBuilder_State;

        private GridControlHelper gridHelper_Record;
        private TB_DailyPlanSignBuilder builder;
        private TB_DailyPlanSignAdapter adapter;


        public UC_DailyPlanSignStatistician()
        {
            InitializeComponent();
        }

        private void UC_DailyPlanSignStatistician_Load(object sender, EventArgs e)
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
            statistician = new DailyPlanSignStatistician(GParam.Create());

            chartHelper_Precent = new ChartControlHelper(chart_Present);
            dataBuilder_Precent = new SingleDataValueSeriesBuilder();
            dataBuilder_Precent.CreateSeries("Precent", DevExpress.XtraCharts.ViewType.Pie);
            dataBuilder_Precent.StyleDesigner.SetPieLengedFormat("{A} - {V}天数");

            chartHelper_State = new ChartControlHelper(chart_State);
            dataBuilder_State = new SingleDataValueSeriesBuilder();
            dataBuilder_State.CreateSeries("State", DevExpress.XtraCharts.ViewType.Bar);
            dataBuilder_State.StyleDesigner.SetBarSeriesEachColor(true);
            dataBuilder_State.StyleDesigner.SetSeriesLengedOption(true, "{A}");

            controller = new DailyPlanSignManageController();
            
            builder = new TB_DailyPlanSignBuilder();
            adapter = new TB_DailyPlanSignAdapter();
            gridHelper_Record = new GridControlHelper(this.gridView_record, this.gridControl_record);
            
        }

        public void onInitialUI()
        {
            DateUtils utils = new DateUtils();
            dateEdit_Start.DateTime = utils.MonthFirstDay(DateTime.Now);
            dateEdit_End.DateTime = utils.MonthLastDay(DateTime.Now);
            ControlAPI.InitialCombox(cmb_PlanItem, new DailyPlanCatalogManageController().TravleAllEntities());
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateEdit_Start.DateTime.Date;
            DateTime endDate = dateEdit_End.DateTime.Date;
            TB_DailyPlanCatalog currentCatalog = cmb_PlanItem.SelectedItem as TB_DailyPlanCatalog;
            //完成日期比例
            dataBuilder_Precent.ClearDataSeries();
            dataBuilder_Precent.AddDataFromTable(statistician.StatisticDailySignPrecent(startDate, endDate, currentCatalog), 0, 1);
            chartHelper_Precent.ReplaceSeries(dataBuilder_Precent.DataSeries);
            //完成状态柱状图
            dataBuilder_State.ClearDataSeries();
            dataBuilder_State.AddDataFromDictonary(statistician.StatisticDailySignState(startDate, endDate, currentCatalog));
            chartHelper_State.ReplaceSeries(dataBuilder_State.DataSeries);
            //完成日历
            schedulerStorage1.Appointments.Clear();
            foreach (var item in controller.QueryEntryByDateAndCatalog(startDate, endDate, currentCatalog.ID))
            {
                Appointment appoint =  schedulerStorage1.Appointments.CreateAppointment(DevExpress.XtraScheduler.AppointmentType.Normal);
                appoint.AllDay = true;
                appoint.Subject = item.Completion;
                appoint.Start = DateTime.Parse(item.Date);
                appoint.End = appoint.End;
                schedulerStorage1.Appointments.Add(appoint);
            }
            schedulerControl1.Start = dateEdit_Start.DateTime;
            if (adapter != null)
            {
                adapter.NotifyClearTable();
                adapter.NotifyDestoryTable();
            }
            //完成列表
            adapter.Initial(controller.QueryEntryByDateAndCatalog(startDate, endDate, currentCatalog.ID), builder);
            adapter.NotifyfreshDataTable();
            gridHelper_Record.GridControl.DataSource = adapter.ResultTable;
            gridHelper_Record.SetAllColumnEditable(false);
            gridHelper_Record.SetAllColumnVisible(false);
            gridHelper_Record.setColunmsVisual(true,builder.Completion, builder.Other, builder.Date);
        }
    }
}
