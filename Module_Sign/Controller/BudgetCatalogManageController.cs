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
    public class BudgetCatalogManageController  : ManageBaseController<TB_BudgetCatalog>
    {
        public BudgetCatalogManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_BudgetCatalogSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_BudgetCatalog entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_BudgetCatalog entry)
        {
            return TB_BudgetCatalogSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_BudgetCatalogSet.ID.Equal(entry);
        }
    }
}
