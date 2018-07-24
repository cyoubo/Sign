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
    public class GYMAPPARATUSManageController : ManageBaseController<TB_GYMAPPARATUS>
    {
        public GYMAPPARATUSManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_GYMAPPARATUSSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_GYMAPPARATUS entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_GYMAPPARATUS entry)
        {
            return TB_GYMAPPARATUSSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_GYMAPPARATUSSet.ID.Equal(entry);
        }

        public bool InsertWithDeleteOldRecord(object baseEntryPK, IList<TB_GYMAPPARATUS> Entries)
        {
            bool result = true;
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                try
                {
                    db.TransactionEnabled = true;
                    db.Remove<TB_GYMAPPARATUSSet>(TB_GYMAPPARATUSSet.BaseID.Equal(baseEntryPK));
                    foreach (var item in Entries)
                    {
                        item.BaseID = long.Parse(baseEntryPK.ToString());
                        db.Add(item);
                    }
                        
                    db.Transaction.Commit();
                }
                catch (Exception ex)
                {
                    result = false;
                    db.Transaction.Rollback();
                    GParam.Create().SystemLogger.Debug("DeleteEntriesByBaseID", ex);
                }
            }
            return result;
        }

        public IList<TB_GYMAPPARATUS> QueryEntriesByBaseID(object baseID)
        {
            List<TB_GYMAPPARATUS> result = new List<TB_GYMAPPARATUS>();
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                try
                {
                    result.AddRange(db.GetEntities<TB_GYMAPPARATUS>(TB_GYMAPPARATUSSet.SelectAll().Where(TB_GYMAPPARATUSSet.BaseID.Equal(baseID))));
                }
                catch (Exception ex)
                {
                    GParam.Create().SystemLogger.Debug("QueryEntriesByBaseID", ex);
                }
            }
            return result;
        }
    }
}
