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
    public class ReadSignManageController : ManageBaseController<TB_BookReadSign>
    {
        public ReadSignManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_BookReadSignSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_BookReadSign entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_BookReadSign entry)
        {
            return TB_BookReadSignSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_BookReadSignSet.ID.Equal(entry);
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryEntryByID(int CurrentID)
        {
            return TB_BookReadSignSet.SelectAll().Where(onBlindIDWhere(CurrentID));
        }

        public bool IsExistReadSign(int currentID)
        {
            bool result = false;
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                result = db.Exist<TB_BookReadSignSet>(TB_BookReadSignSet.ReadPlanID.Equal(currentID));
            }
            return result;
        }

        public IList<TB_BookReadSign> QueryEntriesByReadPlanID(long RealPlanID)
        {
            List<TB_BookReadSign> result = new List<TB_BookReadSign>();
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                result = db.GetEntities<TB_BookReadSign>(TB_BookReadSignSet.SelectAll().Where(TB_BookReadSignSet.ReadPlanID.Equal(RealPlanID)));
            }
            return result;
        }
    }
}
