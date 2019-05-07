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
    public class DailyPlanSignManageController : ManageBaseController<TB_DailyPlanSign>
    {
        public DailyPlanSignManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_DailyPlanSignSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_DailyPlanSign entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_DailyPlanSign entry)
        {
            return TB_DailyPlanSignSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        { 
            return TB_DailyPlanSignSet.ID.Equal(entry);
        }

        public bool InsertEntriesWithDateDelete(IList<TB_DailyPlanSign> list,DateTime signDate)
        {
            bool result = true;
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                try
                {
                    db.TransactionEnabled = true;
                    db.Remove<TB_DailyPlanSignSet>(TB_DailyPlanSignSet.Date.Equal(FormatDate(signDate)));
                    foreach (TB_DailyPlanSign item in list)
                    {
                        item.Date = FormatDate(signDate);
                        db.Add(item);
                    }
                    db.Transaction.Commit();
                }
                catch (Exception ex)
                {
                    db.Transaction.Rollback();
                    result = false;
                    GParam.Create().SystemLogger.Error("InsertEntriesWithDateDelete", ex);
                }
            }
            return result;
        }

        public IList<TB_DailyPlanSign> QueryEntryByDate(DateTime dateTime)
        {
            IList<TB_DailyPlanSign> result = new List<TB_DailyPlanSign>();
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                foreach (var item in db.GetEntities<TB_DailyPlanSign>(TB_DailyPlanSignSet.SelectAll().Where(TB_DailyPlanSignSet.Date.Equal(FormatDate(dateTime)))))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public IList<TB_DailyPlanSign> QueryEntryByDateAndCatalog(DateTime startDate, DateTime endDate, long p)
        {
            IList<TB_DailyPlanSign> result = new List<TB_DailyPlanSign>();
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                var q_Start = TB_DailyPlanSignSet.Date.BiggerThan(FormatDate(startDate));
                var q_End = TB_DailyPlanSignSet.Date.SmallerThan(FormatDate(endDate));
                var q_catalog = TB_DailyPlanSignSet.CatalogID.Equal(p);
                var q_sign = TB_DailyPlanSignSet.IsSign.Equal("True");
                foreach (var item in db.GetEntities<TB_DailyPlanSign>(TB_DailyPlanSignSet.SelectAll().Where(q_Start.And(q_End).And(q_catalog).And(q_sign))))
                {
                    result.Add(item);
                }
            }
            return result;
        }

       
    }
}
