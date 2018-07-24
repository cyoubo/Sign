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
using Sign.Module_Sign.Controller;
using Sign.Module_Sign.Componet.Adapter;
using Sign.Module_Sign.Componet;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Utils;
using Sign.Module_Sign.Model;
using Sign.Module_Sign.Model.Const;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_DailyPlanSignScan : DevExpress.XtraEditors.XtraUserControl, IInitialUI
    {
        private DailyScanTableConstructor constructor;
        private VGridControlHelper vgridHelper;

        public UC_DailyPlanSignScan()
        {
            InitializeComponent();
        }

        private void UC_DailyPlanSignScan_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            constructor = new DailyScanTableConstructor();
            vgridHelper = new VGridControlHelper(this.vGridControl1);
        }

        public void onInitialUI()
        {
            this.Date_Start.DateTime = new DateUtils().GetWeekFirstDayMon(DateTime.Now).Date;
            this.Date_End.DateTime = new DateUtils().GetWeekLastDaySun(DateTime.Now).Date;
            //模拟单击，用于加载默认数据
            btn_Query.PerformClick();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            constructor.SetDateRange(this.Date_Start.DateTime.Date, this.Date_End.DateTime.Date);
            this.vGridControl1.DataSource = constructor.CreateTable();
            this.vgridHelper.SetRowHeight(35);
            this.vgridHelper.BestFitRowHeight();
            this.vgridHelper.SetReadOnly(true);
            //依据状态对单元格着色
            this.vGridControl1.CustomDrawRowValueCell += vGridControl1_CustomDrawRowValueCell;
            
        }

        void vGridControl1_CustomDrawRowValueCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs e)
        {
            TB_DailyPlanSign temp = e.CellValue as TB_DailyPlanSign;
            if (temp != null)
            {
                switch (temp.Completion) 
                { 
                    case EnumDailyPlanState.Well_Done: e.Appearance.BackColor = Color.LightGreen;break;
                    case EnumDailyPlanState.Just_Soso: e.Appearance.BackColor = Color.LightBlue;break;
                    case EnumDailyPlanState.Go_Ahead: e.Appearance.BackColor = Color.LightPink;break;
                    case EnumDailyPlanState.Worse: e.Appearance.BackColor = Color.Pink; break;
                    case EnumDailyPlanState.Trouble: e.Appearance.BackColor = Color.Red; break;
                }
                e.CellText = temp.Other;
            }
        }
    }
}
