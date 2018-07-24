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
using Sign.Module_Sign.Model;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Model.Const;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_CourseEdit : DevExpress.XtraEditors.XtraUserControl, IInitialUI, IValidateInput2, ITabPageCloseCallBack
    {
        private TB_CourseBuilder builder;
        private TB_CourseAdapter adapter;
        private CourseManageController controller;
        private GridControlHelper gridHelper;

        public UC_CourseEdit()
        {
            InitializeComponent();
        }

        private void UC_CourseEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_CourseBuilder();
            adapter = new TB_CourseAdapter();
            controller = new CourseManageController();
            gridHelper = new GridControlHelper(this.gridView_Course, this.gridControl_Course);
        }

        public void onInitialUI()
        {
            dateE_Start.DateTime = DateTime.Now.Date;
            cmb_Catalog.Properties.Items.Clear();
            foreach (var item in new CourseCatalogManageController().TravleAllEntities())
                cmb_Catalog.Properties.Items.Add(item);

            if (adapter != null)
            {
                adapter.NotifyClearTable();
                adapter.NotifyDestoryTable();
            }

            adapter.Initial(controller.TravleAllEntities(), builder);
            adapter.NotifyfreshDataTable();

            gridHelper.GridControl.DataSource = adapter.ResultTable;
            gridHelper.SetColunmOption(builder.ID,false,false);
            gridHelper.SetColunmOption(builder.Name, false, true);
            gridHelper.SetColunmOption(builder.Description, false, true);
            gridHelper.SetColunmOption(builder.CatalogID, false, true);
            gridHelper.SetColunmOption(builder.SumFrequency, false, true);
            gridHelper.SetColunmOption(builder.StarDate, false, true);
            gridHelper.SetColunmOption(builder.EndDate, false, true);
            gridHelper.SetColunmOption(builder.State, false, true);
            gridHelper.SetCellResposity(builder.Op_Delete, this.Repo_HLE_Delete);
            gridHelper.SetCellResposity(builder.Op_Edit, this.Repo_HLE_Update);
            gridHelper.SetCellResposity(builder.Op_Stop, this.Repo_HLE_Stop);
            gridHelper.SetColMaxWidth(builder.Op_Delete, 80);
            gridHelper.SetColMaxWidth(builder.Op_Edit, 80);
            gridHelper.SetColMaxWidth(builder.Op_Stop, 80);
            gridHelper.Group(builder.State);
            gridHelper.GridView.ExpandAllGroups();

        }

        public void onExtractInputValue()
        {
            controller.Entry.CatalogID = (cmb_Catalog.SelectedItem as TB_CourseCatalog).ID;
            controller.Entry.Name = tv_Name.Text;
            controller.Entry.Description = tv_Description.Text;
            controller.Entry.SumFrequency = long.Parse(tv_SumFrequency.Text);
            controller.Entry.StarDate = controller.FormatDate(dateE_Start.DateTime.Date);
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(tv_Name.Text, layoutControlItem1.Text);
            validator.NotNullFinishValidate(tv_SumFrequency.Text, layoutControlItem4.Text);
            validator.NotNullFinishValidate(cmb_Catalog.Text, layoutControlItem3.Text);
            return validator;
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_CourseEdit).Name);
        }

        private void btn_Sure_Click(object sender, EventArgs e)
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
            controller.ReleaseEntry();
            onInitialUI();
        }

        private void Repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            int currentID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            //判断当前课程是否有课程打卡记录
            if (new CourseSignManageController().IsExistCourseSign(currentID))
            {
                MessageBoxHelper.ShowDialog("提示", "当前课程已经有上课记录，不能够删除");
            }
            else 
            {
                if (controller.DeleteEntryByID<TB_CourseSet>(currentID))
                {
                    MessageBoxHelper.ShowDeleteStateDialog(true);
                    onInitialUI();
                }
                else
                    MessageBoxHelper.ShowDeleteStateDialog(false);
            }

        }

        private void Repo_HLE_Update_Click(object sender, EventArgs e)
        {
            controller.CurrentID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            controller.LoadEntry();

            tv_Name.Text = controller.Entry.Name;
            tv_Description.Text = controller.Entry.Description;
            tv_SumFrequency.Text = ""+controller.Entry.SumFrequency;
            dateE_Start.DateTime = DateTime.Parse(controller.Entry.StarDate);
            ControlAPI.SelectedComboxItemByText(cmb_Catalog, new CourseCatalogManageController().QueryEntryByID((int)controller.Entry.CatalogID).Name);
        }

        private void Repo_HLE_Stop_Click(object sender, EventArgs e)
        {
            controller.CurrentID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            controller.LoadEntry();

            string state = gridHelper.getFocuseRowCellValue_String(builder.State);
            if(state.Equals(EnumCourseState.Stop))
            {
                controller.Entry.State = EnumCourseState.Doing;
                controller.Entry.EndDate = "";
                if (controller.UpdateEntryByID())
                    onInitialUI();
                else
                    MessageBoxHelper.ShowUpdateStateDialog(false);
            }
            else if (state.Equals(EnumCourseState.Doing))
            {
                controller.Entry.State = EnumCourseState.Stop;
                controller.Entry.EndDate = controller.FormatDate(DateTime.Now.Date);
                if (controller.UpdateEntryByID())
                    onInitialUI();
                else
                    MessageBoxHelper.ShowUpdateStateDialog(false);
            }
            else
            {
                MessageBoxHelper.ShowDialog("提示", "当前课程已完成，不能修改");
            }
           
        }
    }
}
