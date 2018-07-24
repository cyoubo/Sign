using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Controller;
using Sign.Module_Sign.Model;
using Sign.Module_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Sign.Controller
{
    public class CourseSignManageController : ManageBaseController<TB_CourseSign>
    {
        public CourseSignManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_CourseSignSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_CourseSign entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_CourseSign entry)
        {
            return TB_CourseSignSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_CourseSignSet.ID.Equal(entry);
        }

        public bool IsExistCourseSign(long CourseID)
        {
            bool result = false;
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                result = db.Exist<TB_CourseSignSet>(TB_CourseSignSet.CourseID.Equal(CourseID));
            }
            return result;
        }

        public IList<TB_CourseSign> QueryEntriesByCourseID(long CourseID)
        {
            List<TB_CourseSign> result = new List<TB_CourseSign>();
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                result.AddRange(db.GetEntities<TB_CourseSign>(TB_CourseSignSet.SelectAll().Where(TB_CourseSignSet.CourseID.Equal(CourseID))));
            }
            return result;
        }
    }
}
