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
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Interface;
using Sign.Module_System.Model;
using Sign.Module_Sign.Componet.Adapter;
using Sign.Module_Sign.Controller;
using Sign.Module_Sign.Model.Const;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_BudgetWeed : DevExpress.XtraEditors.XtraUserControl, IInitialUI,IValidateInput2 , ITabPageCloseCallBack
    {
        private TB_BudgetBuilder builder;
        private TB_BudgetAdapter adapter;
        private BudgetManageController controller;
        private GridControlHelper gridHelper;

        public UC_BudgetWeed()
        {
            InitializeComponent();
        }

        private void UC_BudgetWeed_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_BudgetWeed).Name);
        }

       

        public void onCreateComponet()
        {
            builder = new TB_BudgetBuilder();
            adapter = new TB_BudgetAdapter();
            controller = new BudgetManageController();
            gridHelper = new GridControlHelper(this.gridView_Budget, this.gridControl_Budget);
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

            gridHelper.GridControl.DataSource = adapter.ResultTable;
            gridHelper.SetAllColumnEditable(false);
            gridHelper.SetAllColumnVisible(false);
            gridHelper.setColunmsVisual(true, builder.Op_Delete, builder.Op_Edit, builder.State, builder.Actuality, builder.WeedDate, builder.Estimate, builder.SignDate, builder.Name);
            gridHelper.SetCellResposity(builder.Op_Edit, Repo_HLE_Edit);
            gridHelper.SetCellResposity(builder.Op_Delete, Repo_HLE_Delete);


            this.dateE_Weed.DateTime = DateTime.Now.Date;

            tv_Catalog.Text = "";
            tv_Description.Text = "";
            tv_Estimate.Text = "";
            tv_Name.Text = "";
            tv_SignDate.Text = "";
            simpleButton1.Enabled = false;
            btn_RevokeWeed.Enabled = false;
        }

        public void onExtractInputValue()
        {
            controller.Entry.State = EnumBudgetState.Weeded;
            controller.Entry.Actuality = Double.Parse(tv_Actual.Text);
            controller.Entry.WeedDate = controller.FormatDate(dateE_Weed.DateTime.Date);
            controller.Entry.DifferentReason = tv_DiiffReason.Text;
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(this.tv_Actual.Text, layoutControlItem7.Text);
            validator.DateGreaterTodayValidate(this.dateE_Weed.DateTime.Date, layoutControlItem6.Text);
            return validator;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Validator validator = onValidateInputValue();
            if (validator.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
                return;
            }

            onExtractInputValue();
            if(controller.UpdateEntryByID())
            {
                onInitialUI();
                controller.ReleaseEntry();
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);

        }

        private void Repo_HLE_Edit_Click(object sender, EventArgs e)
        {
            controller.CurrentID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            controller.LoadEntry();

            tv_Catalog.Text = gridHelper.getFocuseRowCellValue_String(builder.CatalogName);
            tv_Description.Text = controller.Entry.Description;
            tv_Estimate.Text = ""+controller.Entry.Estimate;
            tv_Name.Text = controller.Entry.Name;
            tv_SignDate.Text = controller.Entry.SignDate;

            tv_Actual.Text = ""+controller.Entry.Actuality;
            if(string.IsNullOrEmpty(controller.Entry.WeedDate)==false)
                dateE_Weed.DateTime =  DateTime.Parse(controller.Entry.WeedDate);
            tv_DiiffReason.Text = controller.Entry.DifferentReason;

            simpleButton1.Enabled = true;
            btn_RevokeWeed.Enabled = true;
        }

        private void btn_RevokeWeed_Click(object sender, EventArgs e)
        {
            controller.Entry.State = EnumBudgetState.Signed;
            controller.Entry.Actuality = 0;
            controller.Entry.WeedDate = "";
            controller.Entry.DifferentReason = "";

            if (controller.UpdateEntryByID())
            {
                onInitialUI();
                controller.ReleaseEntry();
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);
        }
    }
}
