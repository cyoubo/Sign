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
    public class DailyPlanCatalogManageController : ManageBaseController<TB_DailyPlanCatalog>
    {
        public DailyPlanCatalogManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {

            return TB_DailyPlanCatalogSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_DailyPlanCatalog entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_DailyPlanCatalog entry)
        {
            return TB_DailyPlanCatalogSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_DailyPlanCatalogSet.ID.Equal(entry);
        }
    }
}
