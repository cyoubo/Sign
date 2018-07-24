using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Componet;
using Sign.Module_Sign.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Sign.Componet.Command
{
    public class GYMAPPARATUSStatistician
    {
        private IDataBaseFactory mFactory;

        public GYMAPPARATUSStatistician(IDataBaseFactory dbFactory)
        {
            this.mFactory = dbFactory;
        }

        public System.Data.DataTable StatisticDateRangeTypeTotal(long catalogID, DateTime startDate, DateTime endDate)
        {
            DataTable result = new DataTable();
            using (var db = this.mFactory.OpenDefalutDataBase())
            {
                string str_StartDate = startDate.ToString("yyyy-MM-dd");
                string str_EndDate = endDate.ToString("yyyy-MM-dd");
                string sql = string.Format("SELECT TB_GYMBase.Date, TB_GYMAPPARATUS.Weight*TB_GYMAPPARATUS.Frequency*TB_GYMAPPARATUS.GroupCount FROM TB_GYMBase,TB_GYMAPPARATUS where TB_GYMBase.Date BETWEEN '{0}' and '{1}' and TB_GYMAPPARATUS.BaseID = TB_GYMBase.ID and TB_GYMAPPARATUS.CatalogID = {2}", str_StartDate, str_EndDate, catalogID);
                result = db.ExecuteSqlToDataSet(sql).Tables[0];
            }
            return result;
        }

        public int[] StatisticGYMRecordCount(DateTime startDate, DateTime endDate)
        {
            int[] result = new int[3];
            //统计天数
            result[0] = endDate.Date.Subtract(startDate.Date).Days + 1;
            //锻炼天数
            using (var db = this.mFactory.OpenDefalutDataBase())
            {
                string str_StartDate = startDate.ToString("yyyy-MM-dd");
                string str_EndDate = endDate.ToString("yyyy-MM-dd");
                string sql = string.Format("SELECT count(*) FROM TB_GYMBase where TB_GYMBase.Date BETWEEN '{0}' and '{1}'", str_StartDate, str_EndDate);
                object temp = db.ExecuteSqlToDataSet(sql).Tables[0].Rows[0][0];
                result[1] = (temp != null && string.IsNullOrEmpty(temp.ToString()) == false) ? int.Parse(temp.ToString()):0;
            }
            result[2] = result[0]-result[1]; 
            return result;
        }

        public DataTable StatisticGYMDateRangeCatalogSum(DateTime startDate, DateTime endDate)
        {
            DataTable result;
            string str_StartDate = startDate.ToString("yyyy-MM-dd");
            string str_EndDate = endDate.ToString("yyyy-MM-dd");
            using (var db = this.mFactory.OpenDefalutDataBase())
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT TB_GYMCatalog.Name,V.CAL ");
                builder.Append("FROM ( SELECT TB_GYMAPPARATUS.CatalogID, sum(TB_GYMAPPARATUS.Weight * TB_GYMAPPARATUS.Frequency * TB_GYMAPPARATUS.GroupCount) AS CAL ");
                builder.Append("FROM TB_GYMAPPARATUS WHERE TB_GYMAPPARATUS.BaseID ");
                builder.Append("in ( SELECT TB_GYMBase.ID FROM TB_GYMBase WHERE TB_GYMBase.Date BETWEEN '{0}' AND '{1}' ) ");
                builder.Append("GROUP BY TB_GYMAPPARATUS.CatalogID ) AS V, TB_GYMCatalog WHERE V.CatalogID == TB_GYMCatalog.ID");
                string sql = string.Format(builder.ToString(), str_StartDate, str_EndDate);
                result = db.ExecuteSqlToDataSet(sql).Tables[0];
            }
            return result;
        }
    }
}
