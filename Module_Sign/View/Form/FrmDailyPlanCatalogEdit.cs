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
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using Sign.Module_Sign.Controller;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Model;

namespace Sign.Module_Sign.View.Form
{
    public partial class FrmDailyPlanCatalogEdit : DevExpress.XtraEditors.XtraForm, IInitialUI, IValidateInput2
    {

        private TB_DailyPlanCatalogBuilder builder;
        private TB_DailyPlanCatalogAdapter adapter;
        private GridControlHelper helper;
        private DailyPlanCatalogManageController controller;

        public FrmDailyPlanCatalogEdit()
        {
            InitializeComponent();
        }

        private void FrmDailyPlanCatalogEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_DailyPlanCatalogBuilder();
            adapter = new TB_DailyPlanCatalogAdapter();
            helper = new GridControlHelper(this.gridView_dailyscan, this.gridControl_dailyscan);
            controller = new DailyPlanCatalogManageController();
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
            this.gridControl_dailyscan.DataSource = adapter.ResultTable;
            helper.SetAllColumnEditable(false);
            helper.SetColunmOption(builder.ID, false, false);
            helper.SetColunmOption(builder.Op_Delete, true, true);
            helper.SetColunmOption(builder.Op_Edit, true, true);
            helper.SetCellResposity(builder.Op_Delete, this.Repo_HLE_Delete);
            helper.SetCellResposity(builder.Op_Edit, this.Repo_HLE_Edit);

            this.tv_Name.Text = null;
            this.tv_Other.Text = null;
            this.comboBoxEdit1.SelectedIndex = 1;
        }



        public void onExtractInputValue()
        {
            controller.Entry.Name = this.tv_Name.Text;
            controller.Entry.Description = this.tv_Other.Text;
            controller.Entry.Type = this.comboBoxEdit1.Text;
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(this.tv_Name.Text, layoutControlItem1.Text);
            return validator;
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            Validator validator = onValidateInputValue();
            if (validator.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
                return;
            }

            controller.LoadEntry();
            
            onExtractInputValue();

            if (controller.Entry.ID == 0)
                MessageBoxHelper.ShowCreateStateDialog(controller.InsertEntry());
            else
                MessageBoxHelper.ShowUpdateStateDialog(controller.UpdateEntryByID());
            onInitialUI();
        }

        private void Repo_HLE_Edit_Click(object sender, EventArgs e)
        {
            object currentID = this.gridView_dailyscan.GetFocusedRowCellValue(builder.ID);
            controller.CurrentID = int.Parse(currentID.ToString());

            tv_Name.Text = this.gridView_dailyscan.GetFocusedRowCellValue(builder.Name).ToString();
            tv_Other.Text = this.gridView_dailyscan.GetFocusedRowCellValue(builder.Description).ToString();
            ControlAPI.SelectedComboxItemByText(this.comboBoxEdit1,this.gridView_dailyscan.GetFocusedRowCellValue(builder.Description).ToString());
        }

        private void Repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            object currentID = this.gridView_dailyscan.GetFocusedRowCellValue(builder.ID);
            controller.DeleteEntryByID<TB_DailyPlanCatalogSet>(int.Parse(currentID.ToString()));
            onInitialUI();
        }
    }
}