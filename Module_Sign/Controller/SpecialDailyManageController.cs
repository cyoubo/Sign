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
    public class SpecialDailyManageController :  ManageBaseController<TB_SpecialDaily>
    {
        public SpecialDailyManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_SpecialDailySet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_SpecialDaily entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_SpecialDaily entry)
        {
            return TB_SpecialDailySet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_SpecialDailySet.ID.Equal(entry);
        }

        internal IList<TB_SpecialDaily> QueryEntriesByType(string CurrentSpecialDailyType)
        {
            List<TB_SpecialDaily> result = new List<TB_SpecialDaily>();
            using (var db = this.dbFactory.OpenDefalutDataBase())
            { 
                result.AddRange(db.GetEntities<TB_SpecialDaily>(TB_SpecialDailySet.SelectAll().Where(TB_SpecialDailySet.Type.Equal(CurrentSpecialDailyType))));
            }
            return result;
        }
    }
}
