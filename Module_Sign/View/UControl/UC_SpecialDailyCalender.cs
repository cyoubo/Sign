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
using DevExpress.XtraScheduler;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using Sign.Module_System.Model;
using Sign.Module_Sign.Controller;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_SpecialDailyCalender : DevExpress.XtraEditors.XtraUserControl, IInitialUI, ITabPageCloseCallBack
    {
        private SpecialDailyManageController controller;

        public UC_SpecialDailyCalender()
        {
            InitializeComponent();
        }

        private void UC_SpecialDailyCalender_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(this.GetType().Name);
        }

        public void onCreateComponet()
        {
            controller = new SpecialDailyManageController();
        }

        public void onInitialUI()
        {
            this.schedulerStorage1.Appointments.Clear();
            this.schedulerControl1.AppointmentViewInfoCustomizing -= schedulerControl1_AppointmentViewInfoCustomizing;
            this.schedulerControl1.AppointmentViewInfoCustomizing += schedulerControl1_AppointmentViewInfoCustomizing;

            foreach (var item in controller.TravleAllEntities())
            {
                DateTime startDate = DateTime.Parse(item.StartDate);
                DateTime endDate = DateTime.Parse(item.EndDate).AddDays(1);
                Appointment app = this.schedulerStorage1.Appointments.AppointmentFactory.CreateAppointment(AppointmentType.Normal);
                app.AllDay = true;
                app.Subject = item.Type + ":" + item.Other;
                app.Description = item.Color;
                app.Start = startDate;
                app.End = endDate;
                this.schedulerStorage1.Appointments.Add(app);
            }
        }

        void schedulerControl1_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
        {
            DevExpress.XtraScheduler.Drawing.AppointmentViewInfo viewInfo = e.ViewInfo as DevExpress.XtraScheduler.Drawing.AppointmentViewInfo;
            if (viewInfo.Appointment == null)
                return;

            if (viewInfo.Appointment.Description.Equals("0"))
                viewInfo.Appearance.BackColor = Color.Transparent;
            else
                viewInfo.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml(viewInfo.Appointment.Description);//背景色
            
            viewInfo.Appearance.Options.UseBackColor = true;
            viewInfo.Appearance.Options.UseTextOptions = true;
        }
    }
}
