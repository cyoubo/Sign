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
    public class TechniqueEvaluationController : ManageBaseController<TB_TechniqueEvaluation>
    {

        public TechniqueEvaluationController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_TechniqueEvaluationSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_TechniqueEvaluation entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_TechniqueEvaluation entry)
        {
            return TB_TechniqueEvaluationSet.ID.Equal(onGetCurrentEntryID(entry));
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_TechniqueEvaluationSet.ID.Equal(entry);
        }
    }
}
