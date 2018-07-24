using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using Sign.Module_Sign.Componet.Adapter;
using Sign.Module_Sign.Controller;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_System.Model;
using Sign.Module_Sign.Model;
using Sign.Module_Sign.Model.Const;
using Sign.Module_Sign.Componet.Command;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_DailyPlanSignUpdate : DevExpress.XtraEditors.XtraUserControl, IInitialUI, ITabPageCloseCallBack
    {
        private TB_DailyPlanSignBuilder builder;
        private TB_DailyPlanSignAdapter adapter;
        private DailyPlanSignManageController controller;
        private GridControlHelper gridHelper;

        public UC_DailyPlanSignUpdate()
        {
            InitializeComponent();
        }
        private void UC_DailyPlanSignUpdate_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            adapter = new TB_DailyPlanSignAdapter();
            builder = new TB_DailyPlanSignBuilder();
            controller = new DailyPlanSignManageController();
            gridHelper = new GridControlHelper(this.gridView_Sign, this.gridControl_Sign);
        }

        public void onInitialUI()
        {
            this.date_Update.DateTime = DateTime.Now.Date;
            this.cmb_Compelition.Properties.Items.Clear();
            this.cmb_Compelition.Properties.Items.Add(EnumDailyPlanState.Well_Done);
            this.cmb_Compelition.Properties.Items.Add(EnumDailyPlanState.Just_Soso);
            this.cmb_Compelition.Properties.Items.Add(EnumDailyPlanState.Go_Ahead);
            this.cmb_Compelition.Properties.Items.Add(EnumDailyPlanState.Worse);
            this.cmb_Compelition.Properties.Items.Add(EnumDailyPlanState.Trouble);
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_DailyPlanSignUpdate).Name);
        }

        private void date_Update_EditValueChanged(object sender, EventArgs e)
        {
            if (adapter != null)
            {
                adapter.NotifyClearTable();
                adapter.NotifyDestoryTable();
            }

            adapter.Initial(controller.QueryEntryByDate(this.date_Update.DateTime.Date),builder);
            if (adapter.ItemCount == 0)
            {
                MessageBoxHelper.ShowDialog("提示", "当前日期没有打卡记录");
                return;
            }

            adapter.NotifyfreshDataTable();
            this.gridControl_Sign.DataSource = adapter.ResultTable;

            gridHelper.SetAllColumnVisible(false);
            gridHelper.SetColunmOption(builder.CatalogID, false, true);
            gridHelper.HighLightRowByCommand(new DailySignFinishStateHighlightCommand());
        }

        private void gridView_Sign_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            controller.CurrentID = int.Parse(this.gridView_Sign.GetFocusedRowCellValue(builder.ID).ToString());
            controller.LoadEntry();

            ControlAPI.SelectedComboxItemByText(this.cmb_Compelition, controller.Entry.Completion);
            this.Cke_IsSign.Checked = Boolean.Parse(controller.Entry.IsSign);
            this.tv_Other.Text = controller.Entry.Other;
            this.tv_PlanName.Text = this.gridView_Sign.GetFocusedRowCellValue(builder.CatalogID).ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            controller.Entry.Completion = this.cmb_Compelition.Text;
            controller.Entry.IsSign = this.Cke_IsSign.Checked.ToString();
            controller.Entry.Other = this.tv_Other.Text;
            if (controller.UpdateEntryByID())
            {
                MessageBoxHelper.ShowUpdateStateDialog(true);
                //同步更新左侧列表高亮暂未实现
                date_Update_EditValueChanged(this.date_Update, new EventArgs());
            }
            else
            {
                MessageBoxHelper.ShowUpdateStateDialog(false);
            }
            
        }

        private void Cke_IsSign_CheckedChanged(object sender, EventArgs e)
        {
            tv_Other.Text = Cke_IsSign.Checked ? tv_Other.Text : "";
        }
    }
}
