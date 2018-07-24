using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Controller;
using Sign.Module_Sign.Model;
using Sign.Module_Sign.Model.Const;
using Sign.Module_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Sign.Controller
{
    public class CourseManageController: ManageBaseController<TB_Course>
    {
        public CourseManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_CourseSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_Course entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_Course entry)
        {
            return TB_CourseSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_CourseSet.ID.Equal(entry);
        }

        protected override void onBeforeInsert(TB_Course entry)
        {
            base.onBeforeInsert(entry);
            entry.State = EnumCourseState.Doing;
        }
        public IList<TB_Course> QueryDoingCourse()
        {
            List<TB_Course> result = new List<TB_Course>();
            using (var db = this.dbFactory.OpenDefalutDataBase())
            { 
                result.AddRange(db.GetEntities<TB_Course>(TB_CourseSet.SelectAll().Where(TB_CourseSet.State.Equal(EnumCourseState.Doing))));
            }
            return result;
        }



        public string UpdateCourseState(long courseID, long Frequency,DateTime endDate)
        {
            string result = "";
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                try
                {
                    TB_Course course = db.GetEntity<TB_Course>(TB_CourseSet.SelectAll().Where(TB_CourseSet.ID.Equal(courseID)));
                    if (course != null)
                    {
                        if (course.SumFrequency == Frequency)
                        {
                            course.State = EnumCourseState.Done;
                            course.EndDate = FormatDate(endDate);
                            course.WhereExpression = onBlindIDWhere(course);
                            db.Update(course);
                            result = string.Format("祝贺完成 {0} 课程的学习", course.Name);
                        }
                        else if (course.SumFrequency > Frequency)
                        {
                            course.State = EnumCourseState.Doing;
                            course.EndDate = "";
                            course.WhereExpression = onBlindIDWhere(course);
                            db.Update(course);
                            result = string.Format("请 {0} 课程，继续学习...", course.Name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    GParam.Create().SystemLogger.Error("UpdateCourseState", ex);
                    result = "课程记录更新异常...";
                }
            }
            return result;
        }

        public bool IsCalatlogUsed(int catalogID)
        {
            bool result = false;
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                result = db.Exist<TB_CourseSet>(TB_CourseSet.CatalogID.Equal(catalogID));
            }
            return result;
        }
    }
}
