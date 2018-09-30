using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Controller;
using Sign.Module_Technique.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Technique.Controller
{
    public class TechniqueRegisterController : ManageBaseController<TB_TechniqueRegister>
    {
        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_TechniqueRegisterSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_TechniqueRegister entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_TechniqueRegister entry)
        {
            return TB_TechniqueRegisterSet.ID.Equal(onGetCurrentEntryID(entry));
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_TechniqueRegisterSet.ID.Equal(entry);
        }
    }
}
