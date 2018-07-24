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
    public class BudgetManageController : ManageBaseController<TB_Budget>
    {
        public BudgetManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_BudgetSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_Budget entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_Budget entry)
        {
            return TB_BudgetSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_BudgetSet.ID.Equal(entry);
        }

        public bool CheckCatalogIDUsed(int catalogID)
        {
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                return db.Exist<TB_BudgetSet>(TB_BudgetSet.CatalogID.Equal(catalogID));
            }
        }
    }
}
