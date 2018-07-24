using PS.Plot.FrameBasic.Module_Common.Component;
using Sign.Module_Sign.View.UControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_System.Model
{
    public class UIMediator : BaseUIMediator
    {
        public void NotifyUpdateBookCatalog()
        {
            UC_ReadPlanEdit content = GetActor(typeof(UC_ReadPlanEdit).Name) as UC_ReadPlanEdit;
            if (content != null)
                content.onLoadBookCatalog();
        }

        internal void NotifyUpdateBookScan()
        {
            UC_ReadSignScan content = GetActor(typeof(UC_ReadSignScan).Name) as UC_ReadSignScan;
            if (content != null)
                content.onInitialUI();
        }

        internal void NotifyUpdateBookSign()
        {
            UC_ReadSignEdit content = GetActor(typeof(UC_ReadSignEdit).Name) as UC_ReadSignEdit;
            if (content != null)
                content.onInitialUI();
        }

        public void NotifyUpdateGYMSign()
        {
            UC_GYMSignScan content = GetActor(typeof(UC_GYMSignScan).Name) as UC_GYMSignScan;
            if (content != null)
                content.onInitialUI();
        }

        public void NotifyUpdateReadPlan()
        {
            UC_ReadPlanEdit content = GetActor(typeof(UC_ReadPlanEdit).Name) as UC_ReadPlanEdit;
            if (content != null)
                content.onInitialUI();
        }

        internal void NotifyUpdateCourseEdit()
        {
            UC_CourseEdit content = GetActor(typeof(UC_CourseEdit).Name) as UC_CourseEdit;
            if (content != null)
                content.onInitialUI();
        }

        public void NotifyDailyPlanSignScan()
        {
            UC_DailyPlanSignScan content = GetActor(typeof(UC_DailyPlanSignScan).Name) as UC_DailyPlanSignScan;
            if (content != null)
                content.onInitialUI();
        }

        public void NotifySpecialDailyCalender()
        {
            UC_SpecialDailyCalender content = GetActor(typeof(UC_SpecialDailyCalender).Name) as UC_SpecialDailyCalender;
            if (content != null)
                content.onInitialUI();
        }
    }
}
