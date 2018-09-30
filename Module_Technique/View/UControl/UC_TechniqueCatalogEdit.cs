using System;
using PS.Plot.FrameBasic.Module_Common.Interface;
using Sign.Module_Technique.Componet.Adapter;
using Sign.Module_Technique.Controller;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;

namespace Sign.Module_Technique.View.UControl
{
    public partial class UC_TechniqueCatalogEdit : DevExpress.XtraEditors.XtraUserControl, IInitialUI, IValidateInput2
    {
        private TB_TechniqueCatalogBuilder builder;
        private TB_TechniqueCatalogAdapter adapter;
        private TechniqueCatalogController controller;
        private GridControlHelper gridhelper;

        public UC_TechniqueCatalogEdit()
        {
            InitializeComponent();
        }

        private void UC_TechniqueCatalogEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_TechniqueCatalogBuilder();
            adapter = new TB_TechniqueCatalogAdapter();
            gridhelper = new GridControlHelper(this.gridView_Catalog, this.gridControl_Catalog);
            controller = new TechniqueCatalogController();
            controller.LoadEntry();
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

            gridhelper.GridControl.DataSource = adapter.ResultTable;
            gridhelper.SetColunmOption(builder.ID, false, true);
            gridhelper.SetColunmOption(builder.Name, false, true);
            gridhelper.SetColunmOption(builder.Description, false, true);
            gridhelper.SetCellResposity(builder.Op_Edit, repo_HLE_Edit);
            gridhelper.SetCellResposity(builder.Op_Delete, repo_HLE_Delete);
            gridhelper.SetColMaxWidth(builder.Op_Edit, 80);
            gridhelper.SetColMaxWidth(builder.Op_Delete, 80);

            tv_Description.Text = "";
            tv_Name.Text = "";
        }

        public void onExtractInputValue()
        {
            controller.Entry.Name = tv_Name.Text;
            controller.Entry.Description = tv_Description.Text;
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(tv_Name.Text, builder.Name);
            validator.NotNullFinishValidate(tv_Description.Text, builder.Description);
            return validator;
        }

        private void repo_HLE_Edit_Click(object sender, EventArgs e)
        {
            controller.CurrentID = gridhelper.getFocuseRowCellValue_Int(builder.ID);
            controller.LoadEntry();
            tv_Description.Text = controller.Entry.Description;
            tv_Name.Text = controller.Entry.Name;
        }

        private void repo_HLE_Delete_Click(object sender, EventArgs e)
        {
           int currentID = gridhelper.getFocuseRowCellValue_Int(builder.ID);
           if (TechniqueController.IsExitCatalogIDReference(currentID))
           {
               MessageBoxHelper.ShowErrorDialog("当前技术类型已经被使用,请删除后重试...");
               return;
           }
           MessageBoxHelper.ShowDeleteStateDialog(controller.DeleteEntryByID(currentID));
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            Validator validator = onValidateInputValue();
            if (validator.IsValidate)
            {
                onExtractInputValue();

                if (controller.CurrentID == 0)
                    MessageBoxHelper.ShowCreateStateDialog(controller.InsertEntry());
                else
                    MessageBoxHelper.ShowUpdateStateDialog(controller.UpdateEntryByID());
                onInitialUI();
            }
            else
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
        }
    }
}
