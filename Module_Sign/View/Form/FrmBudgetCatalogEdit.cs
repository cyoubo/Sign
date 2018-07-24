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
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Model;

namespace Sign.Module_Sign.View.Form
{
    public partial class FrmBudgetCatalogEdit : DevExpress.XtraEditors.XtraForm, IInitialUI, IValidateInput2
    {
        private TB_BudgetCatalogBuilder builder;
        private TB_BudgetCatalogAdapter adapter;
        private BudgetCatalogManageController controller;
        private GridControlHelper gridHelper;

        public FrmBudgetCatalogEdit()
        {
            InitializeComponent();
        }

        private void FrmBudgetCatalogEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_BudgetCatalogBuilder();
            adapter = new TB_BudgetCatalogAdapter();
            controller = new BudgetCatalogManageController();
            gridHelper = new GridControlHelper(gridView_Catalog, gridControl_Catalog);
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
            gridHelper.setColunmsVisual(false, builder.ID);
            gridHelper.SetCellResposity(builder.Op_Edit, Repo_HLE_Edit);
            gridHelper.SetCellResposity(builder.Op_Delete, Repo_HLE_Delete);

            btnE_Name.Text = "";
            tv_Description.Text = "";
        }

        public void onExtractInputValue()
        {
            controller.Entry.Name = btnE_Name.Text;
            controller.Entry.Description = tv_Description.Text;
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(btnE_Name.Text, layoutControlItem1.Text);
            return validator;
        }

        private void btnE_Name_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Validator validator = onValidateInputValue();
            if (validator.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
                return;
            }

            if (controller.Entry == null)
            {
                controller.LoadEntry();
                onExtractInputValue();
                if (controller.InsertEntry())
                {
                    onInitialUI();
                    controller.ReleaseEntry();
                }
                else
                    MessageBoxHelper.ShowDeleteStateDialog(false);
            }
            else
            {
                onExtractInputValue();
                if (controller.UpdateEntryByID())
                {
                    onInitialUI();
                    controller.ReleaseEntry();
                }
                else
                    MessageBoxHelper.ShowUpdateStateDialog(false);
            }
            
        }

        private void Repo_HLE_Edit_Click(object sender, EventArgs e)
        {
            controller.CurrentID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            controller.LoadEntry();

            tv_Description.Text = controller.Entry.Description;
            btnE_Name.Text = controller.Entry.Name;
        }

        private void Repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            int catalogID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            if (new BudgetManageController().CheckCatalogIDUsed(catalogID))
            {
                MessageBoxHelper.ShowDialog("提示", "当前预算类别已经被使用，不能够删除");
                return;
            }

            if (controller.DeleteEntryByID<TB_BudgetCatalogSet>(catalogID))
            {
                onInitialUI();
            }
            else
                MessageBoxHelper.ShowCreateStateDialog(false);

        }
    }
}