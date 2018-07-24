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
    public class CourseCatalogManageController : ManageBaseController<TB_CourseCatalog>
    {
        public CourseCatalogManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_CourseCatalogSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_CourseCatalog entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_CourseCatalog entry)
        {
            return TB_CourseCatalogSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_CourseCatalogSet.ID.Equal(entry);
        }


    }
}
