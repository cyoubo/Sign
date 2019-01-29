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
using Sign.Module_Sign.Componet.Adapter;
using Sign.Module_Sign.Controller;
using PS.Plot.FrameBasic.Module_Common.Component;
using Sign.Module_Sign.Model;
using Sign.Module_System.Model;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Model.Const;
using DevExpress.XtraScheduler;
using PS.Plot.FrameBasic.Module_Common.Utils;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_ReadSignEdit : DevExpress.XtraEditors.XtraUserControl, IInitialUI, IValidateInput2, ITabPageCloseCallBack
    {
 
        private ReadSignManageController controller;

        public UC_ReadSignEdit()
        {
            InitializeComponent();
        }

        private void UC_ReadSignEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {

            controller = new ReadSignManageController();

            this.calendar_Date.DateTime = DateTime.Now.Date;
            this.dateEdit_Start.DateTime = new DateUtils().MonthFirstDay(DateTime.Now.Date);
            this.dateEdit_End.DateTime = new DateUtils().MonthLastDay(DateTime.Now.Date);
        }

        public void onInitialUI()
        {

            IDictionary<long, string> dict = new ReadPlanManageController().CreateCatalogNameMap();
            this.schedulerStorage1.Appointments.Clear();
            foreach (var item in controller.QueryEntryInDateRange(dateEdit_Start.DateTime.Date, dateEdit_End.DateTime.Date))
            {
                Appointment appoint = this.schedulerStorage1.CreateAppointment(DevExpress.XtraScheduler.AppointmentType.Normal);
                appoint.Start = DateTime.Parse(item.Date);
                appoint.End = DateTime.Parse(item.Date);
                appoint.Subject = dict[item.ReadPlanID];
                appoint.AllDay = true;
                this.schedulerStorage1.Appointments.Add(appoint);
            }
            dict.Clear();
            this.schedulerControl1.Start = this.dateEdit_Start.DateTime;


            cmb_readplan.Properties.Items.Clear();
            foreach (var item in new ReadPlanManageController().QueryUnFinishReadPlan())
                cmb_readplan.Properties.Items.Add(item);
        }

        public void onExtractInputValue()
        {
            controller.Entry.Date = controller.FormatDate(this.calendar_Date.DateTime.Date);
            controller.Entry.ReadPlanID = (cmb_readplan.SelectedItem as TB_BookReadPlan).ID;
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(cmb_readplan.Text, layoutControlItem2.Text);
            return validator;
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_ReadSignEdit).Name);
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
                string state = rg_state.SelectedIndex == 0 ? EnumBookPlanState.Reading : EnumBookPlanState.Read;
                MessageBoxHelper.ShowCreateStateDialog(new ReadPlanManageController().UpdatePlanState(controller.Entry.ReadPlanID, state, calendar_Date.DateTime.Date));
                onInitialUI();
                //如果已经读完，则需要通知更新阅读清单界面
                if (state.Equals(EnumBookPlanState.Read))
                    GParam.Create().Mediator.NotifyUpdateReadPlan();
            }
            else
                MessageBoxHelper.ShowCreateStateDialog(false);
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            this.onInitialUI();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.dateEdit_Start.DateTime = new DateUtils().MonthFirstDay(DateTime.Now.Date);
            this.dateEdit_End.DateTime = new DateUtils().MonthLastDay(DateTime.Now.Date);

            this.onInitialUI();
        }
    }
}
