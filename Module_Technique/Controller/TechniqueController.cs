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
    public class TechniqueController : ManageBaseController<TB_Technique>
    {

        public TechniqueController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_TechniqueSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_Technique entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_Technique entry)
        {
            return TB_TechniqueSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_TechniqueSet.ID.Equal(entry);
        }

        internal static bool IsExitCatalogIDReference(int currentID)
        {
            return true;
        }


    }
}
