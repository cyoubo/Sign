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

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_CourseSignEdit : DevExpress.XtraEditors.XtraUserControl, IInitialUI, IValidateInput2, ITabPageCloseCallBack
    {
        private TB_CourseSignBuilder builder;
        private TB_CourseSignAdapter adapter;
        private CourseSignManageController controller;
        private GridControlHelper gridHelper;

        public UC_CourseSignEdit()
        {
            InitializeComponent();
        }

        private void UC_CourseSignEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_CourseSignBuilder();
            adapter = new TB_CourseSignAdapter();
            controller = new CourseSignManageController();
            gridHelper = new GridControlHelper(this.gridView_Course, this.gridControl_Course);
        }

        public void onInitialUI()
        {
            gridHelper.GridControl.DataSource = null;
            dateE_Date.DateTime = DateTime.Now.Date;
            cmb_CourseName.Properties.Items.Clear();
            foreach (var item in new CourseManageController().QueryDoingCourse())
                cmb_CourseName.Properties.Items.Add(item);
        }

        public void onExtractInputValue()
        {
            controller.Entry.SignDate = controller.FormatDate(this.dateE_Date.DateTime.Date);
            controller.Entry.CourseID = (cmb_CourseName.SelectedItem as TB_Course).ID;
            controller.Entry.Context = tv_Context.Text;
            controller.Entry.Frequency = adapter.ItemCount + 1;
            
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(this.cmb_CourseName.Text,layoutControlItem2.Text);
            validator.NotNullFinishValidate(this.tv_Context.Text, layoutControlItem4.Text);
            return validator;
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_CourseSignEdit).Name);
        }

        private void cmb_CourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_CourseName.SelectedIndex == -1)
                return;

            long CourseID = (cmb_CourseName.SelectedItem as TB_Course).ID;
            if (adapter != null)
            {
                adapter.NotifyClearTable();
                adapter.NotifyDestoryTable();
            }

            adapter.Initial(controller.QueryEntriesByCourseID(CourseID), builder);
            adapter.NotifyfreshDataTable();

            gridHelper.GridControl.DataSource = adapter.ResultTable;
            gridHelper.SetAllColumnEditable(false);
            gridHelper.SetAllColumnVisible(false);

            gridHelper.SetColunmOption(builder.Context, false, true);
            gridHelper.SetColunmOption(builder.SignDate, false, true);
            gridHelper.SetColMaxWidth(builder.SignDate, 120);
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

            if (controller.InsertEntry())
            {
                MessageBoxHelper.ShowCreateStateDialog(true);
                cmb_CourseName_SelectedIndexChanged(this.cmb_CourseName, new EventArgs());
                string result = new CourseManageController().UpdateCourseState(controller.Entry.CourseID, controller.Entry.Frequency,dateE_Date.DateTime.Date);
                if (string.IsNullOrEmpty(result) == false)
                    MessageBoxHelper.ShowDialog("提示", result);
            }
            else
                MessageBoxHelper.ShowCreateStateDialog(false);

        }
    }
}
