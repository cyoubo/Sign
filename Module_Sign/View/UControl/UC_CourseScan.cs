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
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using Sign.Module_System.Model;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Model;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_CourseScan : DevExpress.XtraEditors.XtraUserControl, IInitialUI, IValidateInput2, ITabPageCloseCallBack
    {
        private TB_CourseSignBuilder signBuilder;
        private TB_CourseSignAdapter signAdapter;
        private TB_CourseAdapter courseAdapter;
        private TB_CourseBuilder courseBuilder;

        private CourseSignManageController controller;

        private GridControlHelper courseGridHelper;
        private GridControlHelper signGridHelper;

        public UC_CourseScan()
        {
            InitializeComponent();
        }

        private void UC_CourseScan_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            signBuilder = new TB_CourseSignBuilder();
            signAdapter = new TB_CourseSignAdapter();
            courseAdapter = new TB_CourseAdapter();
            courseBuilder = new TB_CourseBuilder();

            controller = new CourseSignManageController();

            courseGridHelper = new GridControlHelper(this.gridView_Course, this.gridControl_Course);
            signGridHelper = new GridControlHelper(this.gridView_Sign, this.gridControl_Sign);
        }

        public void onInitialUI()
        {
            tv_Context.Text = "";
            tv_Frequency.Text = "";
            dateE_Sign.DateTime = DateTime.Now.Date;

            if (signAdapter != null)
            {
                signAdapter.NotifyClearTable();
                signAdapter.NotifyDestoryTable();
            }

            if (courseAdapter != null)
            {
                courseAdapter.NotifyClearTable();
                courseAdapter.NotifyDestoryTable();
            }

            courseAdapter.Initial(new CourseManageController().TravleAllEntities(), courseBuilder);
            courseAdapter.NotifyfreshDataTable();
            courseGridHelper.GridControl.DataSource = courseAdapter.ResultTable;
            courseGridHelper.SetAllColumnVisible(false);
            courseGridHelper.SetColunmOption(courseBuilder.Name, false, true);
            courseGridHelper.SetColunmOption(courseBuilder.State, false, true);
            
        }

        public void onExtractInputValue()
        {
            controller.Entry.Context = tv_Context.Text;
            controller.Entry.SignDate = controller.FormatDate(this.dateE_Sign.DateTime.Date);
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(tv_Context.Text, layoutControlItem3.Text);
            return validator;
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_CourseScan).Name);
        }

        private void gridView_Course_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int CourseID = courseGridHelper.getFocuseRowCellValue_Int(courseBuilder.ID);
            
            if (signAdapter != null)
            {
                signAdapter.NotifyClearTable();
                signAdapter.NotifyDestoryTable();
            }

            signAdapter.Initial(new CourseSignManageController().QueryEntriesByCourseID(CourseID), signBuilder);
            signAdapter.NotifyfreshDataTable();

            signGridHelper.GridControl.DataSource = signAdapter.ResultTable;
            signGridHelper.SetAllColumnEditable(false);
            signGridHelper.SetColunmOption(signBuilder.ID, false, false);
            signGridHelper.SetColunmOption(signBuilder.CourseID, false, false);
            signGridHelper.SetCellResposity(signBuilder.Op_Delete, Repo_HLE_Delete);
            signGridHelper.SetCellResposity(signBuilder.Op_Edit, Repo_HLE_Edit);
            signGridHelper.SetColunmOption(signBuilder.Op_Delete, true, true);
            signGridHelper.SetColunmOption(signBuilder.Op_Edit, true, true);

            simpleButton1.Enabled = false;
        }

        private void Repo_HLE_Edit_Click(object sender, EventArgs e)
        {
            controller.CurrentID = signGridHelper.getFocuseRowCellValue_Int(signBuilder.ID);
            controller.LoadEntry();
            tv_Context.Text = controller.Entry.Context;
            tv_Frequency.Text = ""+controller.Entry.Frequency;
            dateE_Sign.DateTime = DateTime.Parse(controller.Entry.SignDate);
            this.simpleButton1.Enabled = true;
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

            if (controller.UpdateEntryByID())
            {
                MessageBoxHelper.ShowUpdateStateDialog(true);
                gridView_Course_RowClick(this.gridControl_Course, null);
            }
            else
            {
                MessageBoxHelper.ShowUpdateStateDialog(true);
            }
        }

        private void Repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            if (controller.DeleteEntryByID<TB_CourseSignSet>(signGridHelper.getFocuseRowCellValue_Int(signBuilder.ID)))
            {
                gridView_Course_RowClick(this.gridControl_Course, null);
                string message = new CourseManageController().UpdateCourseState(signGridHelper.getFocuseRowCellValue_Int(signBuilder.CourseID), signAdapter.ItemCount, DateTime.Now);
                if (string.IsNullOrEmpty(message))
                    MessageBoxHelper.ShowDialog("提示", message);
            }
            else
                MessageBoxHelper.ShowDeleteStateDialog(false);
            
        }
    }
}
