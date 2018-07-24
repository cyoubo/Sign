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
using Sign.Module_Sign.Componet.Adapter;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using Sign.Module_Sign.Controller;
using Sign.Module_System.Model;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Sign.Module_Sign.Model;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools.SortCommand;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Model.Const;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_ReadSignScan : DevExpress.XtraEditors.XtraUserControl, IInitialUI, ITabPageCloseCallBack
    {
        private TB_BookReadSignAdapter SignAdapter;
        private TB_BookReadSignBuilder SignBuilder;
        private GridControlHelper SignGridHelper;
        private ReadSignManageController SignController;

        private TB_ReadPlanAdapter BookAdapter;
        private TB_ReadPlanBuilder BookBuilder;
        private GridControlHelper BookGridHelper;
        private ReadPlanManageController BookController;

        public UC_ReadSignScan()
        {
            InitializeComponent();
        }

        private void UC_ReadSignScan_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }
    
        public void onCreateComponet()
        {
            SignAdapter = new TB_BookReadSignAdapter();
            SignBuilder = new TB_BookReadSignBuilder();
            SignGridHelper = new GridControlHelper(this.gridView_ReadSign, this.gridControl_ReadSign);
            SignController = new ReadSignManageController();

            BookAdapter = new TB_ReadPlanAdapter();
            BookBuilder = new TB_ReadPlanBuilder();
            BookGridHelper = new GridControlHelper(this.gridView_ReadPlan, this.gridControl_ReadPlan);
            BookController = new ReadPlanManageController();
        }

        public void onInitialUI()
        {
            if (BookAdapter != null)
            {
                BookAdapter.NotifyClearTable();
                BookAdapter.NotifyDestoryTable();
            }

            BookAdapter.Initial(this.BookController.TravleAllEntities(), BookBuilder);
            BookAdapter.NotifyfreshDataTable();

            this.BookGridHelper.GridControl.DataSource = BookAdapter.ResultTable;
            this.BookGridHelper.Order(BookBuilder.StartDate, new SortByDateCommand(true));

            BookGridHelper.SetAllColumnVisible(false);
            BookGridHelper.SetAllColumnEditable(false);
            BookGridHelper.setColunmsVisual(true, BookBuilder.BookName,BookBuilder.State);
            BookGridHelper.SetColMaxWidth(BookBuilder.State, 60);

            dateE_Sign.DateTime = DateTime.Now.Date;
            btn_update.Enabled = false;
        }

        private void gridView_ReadPlan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            long RealPlanID = this.BookGridHelper.getFocuseRowCellValue_Long(BookBuilder.ID);

            if (SignAdapter != null)
            {
                SignAdapter.NotifyClearTable();
                SignAdapter.NotifyDestoryTable();
            }

            SignAdapter.Initial(this.SignController.QueryEntriesByReadPlanID(RealPlanID), SignBuilder);
            SignAdapter.NotifyfreshDataTable();

            this.SignGridHelper.GridControl.DataSource = SignAdapter.ResultTable;
            this.SignGridHelper.Order(SignBuilder.Date, new SortByDateCommand(true));

            SignGridHelper.SetAllColumnEditable(false);
            SignGridHelper.setColunmsVisual(false, this.SignBuilder.ID,this.SignBuilder.BookName,SignBuilder.ReadPlanID);
            SignGridHelper.setColunmsEdit(true, SignBuilder.Op_Delete, SignBuilder.Op_Edit);
            SignGridHelper.SetCellResposity(SignBuilder.Op_Edit, Repo_HLE_Edit);
            SignGridHelper.SetCellResposity(SignBuilder.Op_Delete, Repo_HLE_Delete);
            
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_ReadSignScan).Name);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (SignController.Entry != null)
            {
                SignController.Entry.Other = tv_Other.Text;
                SignController.Entry.Date= SignController.FormatDate(dateE_Sign.DateTime);

                if (SignController.UpdateEntryByID())
                {
                    onInitialUI();
                    gridView_ReadPlan_RowClick(this.gridControl_ReadSign, null);
                    SignController.ReleaseEntry();
                }
                else
                    MessageBoxHelper.ShowUpdateStateDialog(false);
            }
            
        }

        private void Repo_HLE_Edit_Click(object sender, EventArgs e)
        {
            SignController.CurrentID = SignGridHelper.getFocuseRowCellValue_Int(SignBuilder.ID);
            SignController.LoadEntry();

            tv_Other.Text = SignController.Entry.Other;
            dateE_Sign.DateTime = DateTime.Parse(SignController.Entry.Date);

            btn_update.Enabled = true;
        }

        private void Repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            int SignID = SignGridHelper.getFocuseRowCellValue_Int(SignBuilder.ID);
            if (SignController.DeleteEntryByID<TB_BookReadSignSet>(SignID))
            {
                int readplan = SignGridHelper.getFocuseRowCellValue_Int(SignBuilder.ReadPlanID);
                if (SignAdapter.ItemCount - 1 == 0)
                    new ReadPlanManageController().RevokeReadingState(readplan);
                else
                    new ReadPlanManageController().RevokeReadState(readplan);
                onInitialUI();
                gridView_ReadPlan_RowClick(this.gridControl_ReadSign, null);
            }
        }
    }
}
