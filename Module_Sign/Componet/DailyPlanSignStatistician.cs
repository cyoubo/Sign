using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Componet;
using Sign.Module_Sign.Controller;
using Sign.Module_Sign.Model.Const;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Sign.Module_Sign.Componet
{
    public class DailyPlanSignStatistician
    {
        private IDataBaseFactory mFactory;

        public DailyPlanSignStatistician(IDataBaseFactory dbFactory)
        {
            this.mFactory = dbFactory;
        }

        public DataTable StatisticDailyPlanCount(DateTime startDate, DateTime endDate)
        {
            string str_StartDate = startDate.ToString("yyyy-MM-dd");
            string str_EndDate = endDate.ToString("yyyy-MM-dd");

            StringBuilder builder = new StringBuilder();
            builder.Append("SELECT TB_DailyPlanCatalog.Name,R.Times FROM TB_DailyPlanCatalog ");
            builder.Append("LEFT JOIN ( SELECT CatalogID, count(*) AS Times FROM TB_DailyPlanSign ");
            builder.Append(string.Format("WHERE TB_DailyPlanSign.Date > '{0}' AND TB_DailyPlanSign.Date <= '{1}' ", str_StartDate,str_EndDate));
            builder.Append("AND TB_DailyPlanSign.IsSign = 'True' ");
            builder.Append("GROUP BY CatalogID) AS R ON TB_DailyPlanCatalog.ID = R.CatalogID");

            DataTable result = new DataTable();
            try
            {
                using (var db = this.mFactory.OpenDefalutDataBase())
                {
                    result = db.ExecuteSqlToDataSet(builder.ToString()).Tables[0];
                }
            }
            catch (Exception ex)
            {
                mFactory.WriteSystemLog("StatisticDailyPlanCount", ex);
            }
            return result;
        }

        public IDictionary<string, KeyValuePair<object,double>[]> StatisticDailyPlanYearMonthCount(string YearString)
        {
            Dictionary<string, KeyValuePair<object, double>[]> result = new Dictionary<string, KeyValuePair<object, double>[]>();
            foreach (var item in new DailyPlanCatalogManageController().TravleAllEntities())
                result.Add(item.Name, new KeyValuePair<object, double>[12]);
            
            try
            {
                int year = int.Parse(YearString);

                using (var db = this.mFactory.OpenDefalutDataBase())
                {
                    for (int index = 1; index <= 12; index++)
                    {
                        DateTime startDate = new DateTime(year,index,1);
                        DateTime endDate = startDate.AddMonths(1).AddDays(-1);
                        DataTable MonthTable = StatisticDailyPlanCount(startDate, endDate);

                        foreach (DataRow MonthTableRow in MonthTable.Rows)
                        {
                            string value = string.IsNullOrEmpty(MonthTableRow[1].ToString()) ? "0" : MonthTableRow[1].ToString();
                            KeyValuePair<object, double> keypair = new KeyValuePair<object, double>(""+(index)+" 月", double.Parse(value));
                            result[MonthTableRow[0].ToString()][index -1] = keypair;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mFactory.WriteSystemLog("StatisticDailyPlanYearMonthCount", ex);
            }
            
            return result;
        }

        public IList<string> QueryDailyPlanMonthDate()
        {
            IList<string> result = new List<string>();

            StringBuilder builder = new StringBuilder();
            builder.Append("select DISTINCT(strftime('%Y-%m', TB_DailyPlanSign.Date)) AS MonthDate from TB_DailyPlanSign");
            try
            {
                using (var db = this.mFactory.OpenDefalutDataBase())
                {
                    foreach (DataRow row in db.ExecuteSqlToDataSet(builder.ToString()).Tables[0].Rows)
                    {
                        result.Add(row[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                mFactory.WriteSystemLog("QueryDailyPlanMonthDate", ex);
            }
            return result;
        }

        public IList<string> QueryDailyPlanYearDate()
        {
            IList<string> result = new List<string>();

            StringBuilder builder = new StringBuilder();
            builder.Append("select DISTINCT(strftime('%Y', TB_DailyPlanSign.Date)) AS MonthDate from TB_DailyPlanSign");
            try
            {
                using (var db = this.mFactory.OpenDefalutDataBase())
                {
                    foreach (DataRow row in db.ExecuteSqlToDataSet(builder.ToString()).Tables[0].Rows)
                    {
                        result.Add(row[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                mFactory.WriteSystemLog("QueryDailyPlanYearDate", ex);
            }
            return result;
        }

        public DataTable StatisticDailySignPrecent(DateTime startDate, DateTime endDate, Model.TB_DailyPlanCatalog currentCatalog)
        {
            string str_StartDate = startDate.ToString("yyyy-MM-dd");
            string str_EndDate = endDate.ToString("yyyy-MM-dd");

            StringBuilder builder = new StringBuilder();
           
            builder.Append("SELECT count(*) from TB_DailyPlanSign WHERE ");
            builder.Append(string.Format("Date >= '{0}' and Date <='{1}' AND CatalogID = {2} and IsSign = 'True'", str_StartDate, str_EndDate, currentCatalog.ID));

            DataTable result = new DataTable();
            result.Columns.Add(new DataColumn("类型", typeof(string)));
            result.Columns.Add(new DataColumn("天数", typeof(int)));
            try
            {
                using (var db = this.mFactory.OpenDefalutDataBase())
                {
                    object value = db.ExecuteSqlToDataSet(builder.ToString()).Tables[0].Rows[0][0];
                    int count = string.IsNullOrEmpty(value.ToString()) ? 0 : int.Parse(value.ToString());

                    DataRow row = result.NewRow();
                    row[0] = "打卡天数";
                    row[1] = count;
                    DataRow row1 = result.NewRow();
                    row1[0] = "未打卡天数";
                    row1[1] = endDate.Subtract(startDate).Days + 1;

                    result.Rows.Add(row1);
                    result.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                mFactory.WriteSystemLog("StatisticDailySignPrecent", ex);
            }
            return result;
        }

        public IDictionary<string, double> StatisticDailySignState(DateTime startDate, DateTime endDate, Model.TB_DailyPlanCatalog currentCatalog)
        {
            string str_StartDate = startDate.ToString("yyyy-MM-dd");
            string str_EndDate = endDate.ToString("yyyy-MM-dd");

            StringBuilder builder = new StringBuilder();

            builder.Append("SELECT Completion,count(*) from TB_DailyPlanSign WHERE ");
            builder.Append(string.Format("Date >= '{0}' and Date <='{1}' AND CatalogID = {2} ", str_StartDate, str_EndDate, currentCatalog.ID));
            builder.Append("and IsSign = 'True'  GROUP BY Completion");

            IDictionary<string, double> result = new Dictionary<string,double>();
            result.Add(EnumDailyPlanState.Go_Ahead, 0);
            result.Add(EnumDailyPlanState.Just_Soso, 0);
            result.Add(EnumDailyPlanState.Trouble, 0);
            result.Add(EnumDailyPlanState.Well_Done, 0);
            result.Add(EnumDailyPlanState.Worse, 0);

            try
            {
                using (var db = this.mFactory.OpenDefalutDataBase())
                {
                    DataTable table = db.ExecuteSqlToDataSet(builder.ToString()).Tables[0];
                    foreach (DataRow row in table.Rows)
                        result[row[0].ToString()] = double.Parse(row[1].ToString());
                }
            }
            catch (Exception ex)
            {
                mFactory.WriteSystemLog("StatisticDailySignPrecent", ex);
            }
            return result;
        }
    }
}
