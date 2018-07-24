using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Controller;
using Sign.Module_Sign.Model;
using Sign.Module_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Sign.Controller
{
    public class GYMBaseManageController : ManageBaseController<TB_GYMBase>
    {
        public GYMBaseManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_GYMBaseSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_GYMBase entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_GYMBase entry)
        {
            return TB_GYMBaseSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_GYMBaseSet.ID.Equal(entry);
        }

        public void QueryEntryDataRange(out DateTime startDate, out DateTime endDate)
        {
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                string sql = "SELECT max(date(Date)),min(date(Date)) FROM TB_GYMBase";
                DataTable dt = db.ExecuteSqlToDataSet(sql).Tables[0];
                if (dt.Rows.Count != 0 && string.IsNullOrEmpty(dt.Rows[0][0].ToString()) == false)
                {
                    startDate = DateTime.Parse(dt.Rows[0][1].ToString());
                    endDate = DateTime.Parse(dt.Rows[0][0].ToString());
                }
                else
                {
                    startDate = DateTime.Now.Date;
                    endDate = DateTime.Now.Date;
                }
            }
        }

        public IList<TB_GYMBase> TraveleEntriesByDateRange(DateTime startDate, DateTime endDate)
        {
            IList<TB_GYMBase> result = new List<TB_GYMBase>();
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                string str_StartDate = startDate.ToString("yyyy-MM-dd");
                string str_EndDate = endDate.ToString("yyyy-MM-dd");
                string where = string.Format("select * from TB_GYMBase where Date between '{0}' and '{1}'", str_StartDate, str_EndDate);
                foreach (var item in db.ExecuteSqlToOwnList<TB_GYMBase>(where))
                {
                    result.Add(item);
                }  
            }
            return result;
        }
    }
}
