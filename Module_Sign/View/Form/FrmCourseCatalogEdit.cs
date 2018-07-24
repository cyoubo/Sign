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
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using Sign.Module_Sign.Controller;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Model;
using Sign.Module_System.Model;

namespace Sign.Module_Sign.View.Form
{
    public partial class FrmCourseCatalogEdit : DevExpress.XtraEditors.XtraForm, IInitialUI, IValidateInput2
    {
        private TB_CourseCatalogBuilder builder;
        private TB_CourseCatalogAdapter adapter;
        private GridControlHelper gridHelper;
        private CourseCatalogManageController controller;

        public FrmCourseCatalogEdit()
        {
            InitializeComponent();
        }

        private void FrmCourseCatalogEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_CourseCatalogBuilder();
            adapter = new TB_CourseCatalogAdapter();
            controller = new CourseCatalogManageController();
            gridHelper = new GridControlHelper(this.gridView_Catalog, this.gridControl_Catalog);
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
            gridHelper.SetColunmOption(builder.ID, false, false);
            gridHelper.SetColunmOption(builder.Name, false, true);
            gridHelper.SetColunmOption(builder.Other, false, true);
            gridHelper.SetCellResposity(builder.Op_Edit, this.Repo_HLE_Edit);
            gridHelper.SetCellResposity(builder.Op_Delete, this.Repo_HLE_Delete);
        }

        public void onExtractInputValue()
        {
            controller.Entry.Name = btnE_Name.Text;
            controller.Entry.Other = tv_Other.Text;
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(btnE_Name.Text, layoutControlItem1.Text);
            return validator;
        }


        private void Repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            int currentID = int.Parse(this.gridView_Catalog.GetFocusedRowCellValue(builder.ID).ToString());
            if (new CourseManageController().IsCalatlogUsed(currentID))
                MessageBoxHelper.ShowDialog("提示", "当前课程类别已经被使用，不能够删除");
            else
            {
                if (controller.DeleteEntryByID<TB_CourseCatalogSet>(currentID))
                {
                    onInitialUI();
                    GParam.Create().Mediator.NotifyUpdateCourseEdit();
                }
                else
                    MessageBoxHelper.ShowDeleteStateDialog(false);
            }
        }

        private void Repo_HLE_Edit_Click(object sender, EventArgs e)
        {
            controller.CurrentID = this.gridHelper.getFocuseRowCellValue_Int(builder.ID);
            controller.LoadEntry();
            tv_Other.Text = controller.Entry.Other;
            btnE_Name.Text = controller.Entry.Name;
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
                MessageBoxHelper.ShowCreateStateDialog(controller.InsertEntry());
            }
            else
            {
                onExtractInputValue();
                MessageBoxHelper.ShowUpdateStateDialog(controller.UpdateEntryByID());
            }
            onInitialUI();
            controller.ReleaseEntry();

            GParam.Create().Mediator.NotifyUpdateCourseEdit();
        }
    }
}