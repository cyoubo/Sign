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
    public class GYMCatalogManageController : ManageBaseController<TB_GYMCatalog>
    {
        public GYMCatalogManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_GYMCatalogSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_GYMCatalog entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_GYMCatalog entry)
        {
            return TB_GYMCatalogSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_GYMCatalogSet.ID.Equal(entry);
        }

        public bool CheckGYMCatalogHaveReference(int targetID)
        {
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                return db.Exist<TB_GYMAPPARATUSSet>(TB_GYMAPPARATUSSet.CatalogID.Equal(targetID));
            }
        }
    }
}
