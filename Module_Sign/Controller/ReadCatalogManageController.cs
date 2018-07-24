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
    public class ReadCatalogManageController : ManageBaseController<TB_BookCatalog>
    {
        public ReadCatalogManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_BookCatalogSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_BookCatalog entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_BookCatalog entry)
        {
            return TB_BookCatalogSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_BookCatalogSet.ID.Equal(entry);
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryEntryByID(int CurrentID)
        {
            return TB_BookCatalogSet.SelectAll().Where(onBlindIDWhere(CurrentID));
        }

        public bool CheckBookCatalogHaveReference(object targetID)
        {
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                return db.Exist<TB_BookReadPlanSet>(TB_BookReadPlanSet.Catalog.Equal(targetID));
            }
        }
    }
}
