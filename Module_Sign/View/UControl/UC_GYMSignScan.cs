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
using Sign.Module_Sign.Controller;
using Sign.Module_Sign.Componet.Adapter;
using Sign.Module_System.Model;
using Sign.Module_Sign.Model;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools.SortCommand;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_GYMSignScan : DevExpress.XtraEditors.XtraUserControl,IInitialUI, ITabPageCloseCallBack
    {

        private GYMBaseManageController gymbaseController;
        private GYMAPPARATUSManageController gymAppController;

        private TB_GYMAPPARATUSAdapter appAdaptor;
        private TB_GYMAPPARATUSBuilder appBuilder;
        private TB_GYMBaseAdapter baseAdaptor;
        private TB_GYMBaseBuilder baseBuilder;

        private GridControlHelper gridHelper_Base;
        private GridControlHelper gridHelper_App;

        public UC_GYMSignScan()
        {
            InitializeComponent();
        }

        private void UC_GYMSignScan_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            gymbaseController = new GYMBaseManageController();
            gymAppController = new GYMAPPARATUSManageController();
            appAdaptor = new TB_GYMAPPARATUSAdapter();
            appBuilder = new TB_GYMAPPARATUSBuilder();
            baseAdaptor = new TB_GYMBaseAdapter();
            baseBuilder = new TB_GYMBaseBuilder();

            gridHelper_Base = new GridControlHelper(this.gridView_signscan, this.gridControl_signscan);
            gridHelper_App = new GridControlHelper(this.gridView_appScan,this.gridControl_appScan);
        }

        public void onInitialUI()
        {
            if(baseAdaptor!=null)
            {
                baseAdaptor.NotifyClearTable();
                baseAdaptor.NotifyDestoryTable();
            }
            baseAdaptor.Initial(gymbaseController.TravleAllEntities(), baseBuilder);
            baseAdaptor.NotifyfreshDataTable();
            this.gridControl_signscan.DataSource = baseAdaptor.ResultTable;
            this.gridHelper_Base.SetAllColumnEditable(false);
            this.gridHelper_Base.SetAllColumnVisible(false);
            this.gridHelper_Base.SetColunmOption(baseBuilder.Date, false, true);
            this.gridHelper_Base.Order(baseBuilder.Date, new SortByDateCommand(true));

            this.dateE_Date.Text = null;
            this.tv_Calorie.Text = null;
            this.tv_Other.Text = null;
            this.btn_Delete.Enabled = false;
            this.btn_Update.Enabled = false;
            this.gridControl_appScan.DataSource = null;
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_GYMSignScan).Name);
        }

        private void gridView_signscan_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            object baseID = this.gridView_signscan.GetFocusedRowCellValue(baseBuilder.ID);
            gymbaseController.CurrentID = int.Parse(baseID.ToString());
            gymbaseController.LoadEntry();
            this.dateE_Date.DateTime = DateTime.Parse(gymbaseController.Entry.Date);
            this.tv_Calorie.Text = ""+gymbaseController.Entry.Calorie;
            this.tv_Other.Text = gymbaseController.Entry.Other;

            if (appAdaptor != null)
            {
                appAdaptor.NotifyClearTable();
                appAdaptor.NotifyDestoryTable();
            }

            appAdaptor.Initial(gymAppController.QueryEntriesByBaseID(baseID), appBuilder);
            appAdaptor.NotifyfreshDataTable();
            this.gridControl_appScan.DataSource = appAdaptor.ResultTable;
            this.gridHelper_App.SetColunmOption(appBuilder.ID, false, false);
            this.gridHelper_App.SetColunmOption(appBuilder.BaseID, false, false);
            this.gridHelper_App.SetCellResposity(appBuilder.Op_Delete, this.Repo_HLE_Delete);
            this.btn_Update.Enabled = true;
            this.btn_Delete.Enabled = true;
        }

        private void Repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            object appID = this.gridView_appScan.GetFocusedRowCellValue(appBuilder.ID);
            gymAppController.DeleteEntryByID<TB_GYMAPPARATUSSet>(int.Parse(appID.ToString()));

            appAdaptor.Initial(gymAppController.QueryEntriesByBaseID(gymbaseController.CurrentID), appBuilder);
            appAdaptor.NotifyfreshDataTable();
            this.gridControl_appScan.DataSource = appAdaptor.ResultTable;
            this.gridHelper_App.SetColunmOption(appBuilder.ID, false, false);
            this.gridHelper_App.SetColunmOption(appBuilder.BaseID, false, false);
            this.gridHelper_App.SetCellResposity(appBuilder.Op_Delete, this.Repo_HLE_Delete);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (gymbaseController.Entry != null)
            {
                gymbaseController.Entry.Calorie = long.Parse(tv_Calorie.Text);
                gymbaseController.Entry.Other = tv_Other.Text;
                MessageBoxHelper.ShowUpdateStateDialog(gymbaseController.UpdateEntryByID());
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (gymbaseController.Entry != null)
            {
                bool result = gymbaseController.DeleteEntry<TB_GYMBaseSet>();
                if (result)
                {
                    gymbaseController.ReleaseEntry();
                    onInitialUI();
                }
                MessageBoxHelper.ShowUpdateStateDialog(result);
            }
        }
    }
}
