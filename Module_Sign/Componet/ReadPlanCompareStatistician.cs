using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Componet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Sign.Componet
{
    public class ReadPlanCompareStatistician
    {
        private IDataBaseFactory mFactory;

        public ReadPlanCompareStatistician(IDataBaseFactory dbFactory)
        {
            this.mFactory = dbFactory;
        }

        public DataTable StatisticianReadDays(DateTime startDate, DateTime endDate)
        {

            string str_StartDate = startDate.ToString("yyyy-MM-dd");
            string str_EndDate = endDate.ToString("yyyy-MM-dd");
            int dayrange = (endDate - startDate).Days + 1;

            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("状态", typeof(string)));
            table.Columns.Add(new DataColumn("天数", typeof(string)));

            string sql = string.Format("SELECT count(*) FROM TB_BookReadSign where Date >= '{0}' AND Date<='{1}'", str_StartDate, str_EndDate);

            try
            {
                using (var db = mFactory.OpenDefalutDataBase())
                {
                    string value = db.ExecuteSqlToDataSet(sql).Tables[0].Rows[0][0].ToString();
                    int readdays = string.IsNullOrEmpty(value) ? 0 : int.Parse(value);

                    DataRow row = table.NewRow();
                    row[0] = "读书天数"; row[1] = readdays;
                    table.Rows.Add(row);
                    DataRow row2 = table.NewRow();
                    row2[0] = "未读书天数"; row2[1] = dayrange - readdays;
                    table.Rows.Add(row2);
                }
            }
            catch (Exception ex)
            {
                mFactory.WriteSystemLog("StatisticianReadDays", ex);
            }

            return table;
        }

        public DataTable StatisticianReadPlanStruction(DateTime startDate, DateTime endDate, params string[] states)
        {
            for (int index = 0; index < states.Length; index++)
                states[index] = string.Format("'{0}'", states[index]);

            string str_StartDate = startDate.ToString("yyyy-MM-dd");
            string str_EndDate = endDate.ToString("yyyy-MM-dd");

            StringBuilder builder = new StringBuilder();
            builder.Append("SELECT TB_BookCatalog.Name , R.Num ");
            builder.Append("from TB_BookCatalog LEFT JOIN ");
            builder.Append(string.Format("(SELECT TB_BookReadPlan.Catalog, count(*) as Num From TB_BookReadPlan where TB_BookReadPlan.State in ({0}) ", string.Join(" , ", states)));
            builder.Append(string.Format("AND TB_BookReadPlan.CreateDate >= '{0}' and TB_BookReadPlan.CreateDate < '{1}' ", str_StartDate, str_EndDate));
            builder.Append("GROUP BY TB_BookReadPlan.Catalog) as R  ON TB_BookCatalog.ID = R.Catalog");

            DataTable table = new DataTable();

            try
            {
                using (var db = mFactory.OpenDefalutDataBase())
                {
                    table = db.ExecuteSqlToDataSet(builder.ToString()).Tables[0];
                }
            }
            catch (Exception ex)
            {
                mFactory.WriteSystemLog("StatisticianReadDays", ex);
            }

            return table;
        }

        public IDictionary<string, double> StatisticianReadPlanState(DateTime startDate, DateTime endDate)
        {
            string str_StartDate = startDate.ToString("yyyy-MM-dd");
            string str_EndDate = endDate.ToString("yyyy-MM-dd");

            StringBuilder builder = new StringBuilder();
            builder.Append("SELECT State, count(*) from TB_BookReadPlan ");
            builder.Append(string.Format("WHERE CreateDate >= '{0}' AND CreateDate <= '{1}' ", str_StartDate, str_EndDate));
            builder.Append("GROUP BY State");

            IDictionary<string, double> result = new Dictionary<string, double>();
            string[] keys = new string[] { "读过", "想读", "在读", "放弃" };
            foreach (var key in keys)
                result.Add(key, 0);


            try
            {
                using (var db = mFactory.OpenDefalutDataBase())
                {
                    DataTable table = db.ExecuteSqlToDataSet(builder.ToString()).Tables[0];
                    foreach (DataRow row in table.Rows)
                    {
                        result[row[0].ToString()] = int.Parse(row[1].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                mFactory.WriteSystemLog("StatisticianReadPlanState", ex);
            }

            return result;
        }

        public void QueryReadPlanDateRange(ref DateTime startDate, ref DateTime endDate)
        {
            try
            {
                using (var db = mFactory.OpenDefalutDataBase())
                {
                    DataTable table = db.ExecuteSqlToDataSet("SELECT min(CreateDate),max(CreateDate)from TB_BookReadPlan").Tables[0];
                    DataRow rows = table.Rows[0];
                    startDate = string.IsNullOrEmpty(rows[0].ToString()) ? DateTime.Now.Date : DateTime.Parse(rows[0].ToString());
                    endDate = string.IsNullOrEmpty(rows[1].ToString()) ? DateTime.Now.Date : DateTime.Parse(rows[1].ToString());
                }
            }
            catch (Exception ex)
            {
                mFactory.WriteSystemLog("QueryReadPlanDateRange", ex);
            }
        }

        public DataTable StatisticianFinishStateByMonth(int year)
        {
            DataTable result = new DataTable();
            result.Columns.Add(new DataColumn("月份", typeof(string)));
            result.Columns.Add(new DataColumn("书目", typeof(string)));
            try
            {
                using (var db = mFactory.OpenDefalutDataBase())
                {
                    IList<string> books = new List<string>();
                    for (int month = 1; month <= 12; month++)
                    {
                        DataRow resultRow = result.NewRow();
                        string str_Month = "" + year + "-" + month.ToString("d2");
                        string sql = string.Format("SELECT BookName FROM TB_BookReadPlan where State = '读过' and EndDate LIKE '{0}%'", str_Month);
                        books.Clear();
                        foreach (DataRow row in db.ExecuteSqlToDataSet(sql).Tables[0].Rows)
                            books.Add(row[0].ToString());
                        resultRow[0] = month + "月";
                        resultRow[1] = string.Join("/", books);
                        result.Rows.Add(resultRow);
                    }
                }
            }
            catch (Exception ex)
            {
                mFactory.WriteSystemLog("StatisticianFinishStateByMonth", ex);
            }
            return result;
        }

        public IList<string> QueryReadPlanSignYear()
        {
            IList<string> result = new List<string>();
            try
            {
                using (var db = mFactory.OpenDefalutDataBase())
                {
                    string sql = string.Format("select DISTINCT(strftime('%Y', TB_BookReadSign.Date)) from TB_BookReadSign ORDER BY Date DESC");
                    foreach (DataRow row in db.ExecuteSqlToDataSet(sql).Tables[0].Rows)
                        result.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                mFactory.WriteSystemLog("QueryReadPlanSignYear", ex);
            }
            return result;
        }
    }
}
