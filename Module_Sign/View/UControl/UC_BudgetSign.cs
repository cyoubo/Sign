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
using Sign.Module_Sign.Componet.Adapter;
using Sign.Module_Sign.Controller;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_Common.Component;
using Sign.Module_System.Model;
using Sign.Module_Sign.Model;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Componet;
using Sign.Module_Sign.Model.Const;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_BudgetSign : DevExpress.XtraEditors.XtraUserControl, IInitialUI, IValidateInput2, ITabPageCloseCallBack
    {
        private TB_BudgetBuilder builder;
        private TB_BudgetAdapter adapter;
        private BudgetManageController controller;
        private GridControlHelper gridHelper;

        public UC_BudgetSign()
        {
            InitializeComponent();
        }

        private void UC_BudgetSign_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
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
            gridHelper.setColunmsVisual(false, builder.ID, builder.Actuality, builder.WeedDate, builder.Op_Detail,builder.CatalogID,builder.DifferentReason);
            gridHelper.SetCellResposity(builder.Op_Edit, Repo_HLE_Edit);
            gridHelper.SetCellResposity(builder.Op_Delete, Repo_HLE_Delete);


            this.dateE_Sign.DateTime = DateTime.Now.Date;
            this.cmb_Catalog.Properties.Items.Clear();
            foreach (var item in new BudgetCatalogManageController().TravleAllEntities())
                this.cmb_Catalog.Properties.Items.Add(item);

            tv_Statistic.Text = new BudgetStatistician().Statistic(GParam.Create()).toDisplayString();
        }

        public void onExtractInputValue()
        {
            controller.Entry.Name = tv_Name.Text;
            controller.Entry.Description = tv_Description.Text;
            controller.Entry.SignDate = controller.FormatDate(dateE_Sign.DateTime.Date);
            controller.Entry.Estimate = Double.Parse(tv_Estimate.Text);
            controller.Entry.CatalogID = (cmb_Catalog.SelectedItem as TB_BudgetCatalog).ID;
            controller.Entry.Level = (long)rating_Level.Rating;
            controller.Entry.State = EnumBudgetState.Signed;
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(tv_Name.Text, layoutControlItem1.Text);
            validator.DateGreaterTodayValidate(this.dateE_Sign.DateTime, layoutControlItem4.Text);
            validator.NotNullFinishValidate(tv_Estimate.Text, layoutControlItem5.Text);
            validator.NotNullFinishValidate(cmb_Catalog.Text, layoutControlItem3.Text);
            return validator;
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_BudgetSign).Name);
        }


        private void btn_Sure_Click(object sender, EventArgs e)
        {
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
                    MessageBoxHelper.ShowCreateStateDialog(false);
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
            tv_Name.Text = controller.Entry.Name;
            tv_Estimate.Text = "" + controller.Entry.Estimate;
            dateE_Sign.DateTime = DateTime.Parse(controller.Entry.SignDate);
            ControlAPI.SelectedComboxItemByText(cmb_Catalog, gridHelper.getFocuseRowCellValue_String(builder.CatalogName));
            rating_Level.Rating = Decimal.Parse(controller.Entry.Level.ToString());
        }

        private void Repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            int currentID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            if (controller.DeleteEntryByID<TB_BudgetSet>(currentID))
            {
                onInitialUI();
            }
            else
                MessageBoxHelper.ShowDeleteStateDialog(false);
        }
    }
}
