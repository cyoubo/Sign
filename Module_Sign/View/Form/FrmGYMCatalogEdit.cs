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
using PS.Plot.FrameBasic.Module_Common.Interface;
using Sign.Module_Sign.Componet.Adapter;
using Sign.Module_Sign.Controller;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Model;

namespace Sign.Module_Sign.View.Form
{
    public partial class FrmGYMCatalogEdit : DevExpress.XtraEditors.XtraForm, IInitialUI, IValidateInput
    {
        private TB_GYMCatalogAdapter adapter;
        private TB_GYMCatalogBuilder builder;
        private GYMCatalogManageController controller;
        private GridControlHelper gridHelper;

        public FrmGYMCatalogEdit()
        {
            InitializeComponent();
        }

        public void onCreateComponet()
        {
            adapter = new TB_GYMCatalogAdapter();
            builder = new TB_GYMCatalogBuilder();
            controller = new GYMCatalogManageController();
            gridHelper = new GridControlHelper(this.gridView_gymcatalog, this.gridControl_gymcatalog);
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

            this.gridControl_gymcatalog.DataSource = adapter.ResultTable;
            gridHelper.SetColunmOption(builder.ID, false, false);
            gridHelper.SetColunmOption(builder.Name, false, true);
            gridHelper.SetCellResposity(builder.Op_Delete, this.Repos_HLE_Delete);
            gridHelper.SetCellResposity(builder.Op_Edit, this.Repos_HLE_Edit);
        }

        private void FrmGYMCatalogEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }



        public void onExtractInputValue()
        {
            controller.Entry.Name = this.btn_Name.Text;
            controller.Entry.Description = this.tv_Des.Text;
        }

        public bool onValidateInputValue(out string Message)
        {
            Message = "";
            Validator.NotNullFinishValidate(this.btn_Name.Text, layoutControlItem1.Text, ref Message);
            return string.IsNullOrEmpty(Message);
        }

        private void Repos_HLE_Delete_Click(object sender, EventArgs e)
        {
            int targetID = (int)adapter[gridView_gymcatalog.FocusedRowHandle].ID;
            if (controller.CheckGYMCatalogHaveReference(targetID))
            {
                MessageBoxHelper.ShowDialog("提示", "当前类型已经在[锻炼记录]中使用，请先删除关联记录后重试");
            }
            else
            {
                bool result = controller.DeleteEntryByID<TB_GYMCatalogSet>(targetID);
                if (result)
                    onInitialUI();
                else
                    MessageBoxHelper.ShowDeleteStateDialog(false);
            }
        }

        private void Repos_HLE_Edit_Click(object sender, EventArgs e)
        {
            controller.CurrentID = (int)adapter[gridView_gymcatalog.FocusedRowHandle].ID;
            btn_Name.Text = adapter[gridView_gymcatalog.FocusedRowHandle].Name;
            tv_Des.Text = adapter[gridView_gymcatalog.FocusedRowHandle].Description;
        }

        private void FrmGYMCatalogEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            
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
        }


    }
}