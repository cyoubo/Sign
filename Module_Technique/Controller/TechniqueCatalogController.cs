using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Controller;
using Sign.Module_System.Model;
using Sign.Module_Technique.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Technique.Controller
{
    public class TechniqueCatalogController : ManageBaseController2<TB_TechniqueCatalog, TB_TechniqueCatalogSet>
    {
        public TechniqueCatalogController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_TechniqueCatalogSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_TechniqueCatalog entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_TechniqueCatalog entry)
        {
            return TB_TechniqueCatalogSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_TechniqueCatalogSet.ID.Equal(entry);
        }

        public static long ExtractID(object source)
        {
            return (source as TB_TechniqueCatalog).ID;
        }
    }
}
