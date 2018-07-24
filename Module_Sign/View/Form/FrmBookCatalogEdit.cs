using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Sign.Module_Sign.Componet.Adapter;
using Sign.Module_Sign.Controller;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Component;
using Sign.Module_Sign.Model;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_System.Model;

namespace Sign.Module_Sign.View.Form
{
    public partial class FrmBookCatalogEdit : DevExpress.XtraEditors.XtraForm,IInitialUI,IValidateInput
    {
        public string NewCatalog { get; set; }

        private TB_BookCatalogBuilder builder;
        private TB_BookCatalogAdapter adapter;
        private GridControlHelper helper;
        private ReadCatalogManageController controller;

        public FrmBookCatalogEdit()
        {
            InitializeComponent();
        }
        private void FrmBookCatalogEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        private void FrmBookCatalogEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            GParam.Create().Mediator.NotifyUpdateBookCatalog();
        }

        public void onCreateComponet()
        {
            builder = new TB_BookCatalogBuilder();
            adapter = new TB_BookCatalogAdapter();
            helper = new GridControlHelper(this.gridView_BookCatalog, this.gridControl_BookCatalog);
            controller = new ReadCatalogManageController();
        }

        public void onInitialUI()
        {
            if (adapter != null)
            {
                adapter.NotifyClearTable();
                adapter.NotifyDestoryTable();
            }

            adapter.Initial(controller.TravleAllEntities(), builder);
            adapter.NotifyfreshDataTable();

            this.gridControl_BookCatalog.DataSource = adapter.ResultTable;
            helper.SetColunmOption(builder.ID, false, false);
            helper.SetColunmOption(builder.Name, false, true);
            helper.SetCellResposity(builder.Op_Delete, this.Repos_HLE_Delete);
            helper.SetCellResposity(builder.Op_Edit, this.Repos_HLE_Edit);
        }

        public void onExtractInputValue()
        {
            controller.Entry.Name = this.btn_Name.Text;
        }

        public bool onValidateInputValue(out string Message)
        {
           Message = "";
           Validator.NotNullFinishValidate(this.btn_Name.Text, layoutControlItem4.Text, ref Message);
           return string.IsNullOrEmpty(Message);
        }

        private void Repos_HLE_Delete_Click(object sender, EventArgs e)
        {
           int targetID =  (int)adapter[gridView_BookCatalog.FocusedRowHandle].ID;
           if (controller.CheckBookCatalogHaveReference(targetID))
           {
               MessageBoxHelper.ShowDialog("提示", "当前类型已经在[阅读记录]中使用，请先删除关联记录后重试");
           }
           else
           {
               if (controller.DeleteEntryByID<TB_BookCatalogSet>(targetID))
               {
                   onInitialUI();
                   GParam.Create().Mediator.NotifyUpdateReadPlan();
               }
               else
                   MessageBoxHelper.ShowDeleteStateDialog(false);
           }
           
        }

        private void btn_Name_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            controller.LoadEntry();
            string message = "";
            if (onValidateInputValue(out message) == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(message);
                controller.ReleaseEntry();
                return;
            }

            onExtractInputValue();
            if (controller.CurrentID == 0)
                MessageBoxHelper.ShowCreateStateDialog(controller.InsertEntry());
            else
                MessageBoxHelper.ShowUpdateStateDialog(controller.UpdateEntryByID());

            onInitialUI();

            GParam.Create().Mediator.NotifyUpdateReadPlan();
        }

        private void Repos_HLE_Edit_Click(object sender, EventArgs e)
        {
            controller.CurrentID = (int)adapter[gridView_BookCatalog.FocusedRowHandle].ID;
            btn_Name.Text = adapter[gridView_BookCatalog.FocusedRowHandle].Name;
        }
    }
}