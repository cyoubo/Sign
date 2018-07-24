using Sign.Module_Sign.Controller;
using Sign.Module_Sign.Model;
using Sign.Module_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Sign.Componet
{
    public class DailyScanTableConstructor
    {
        private DataTable ResultTable;
        private DateTime StartDate;
        private DateTime EndDate;

        public void SetDateRange(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public DataTable CreateTable()
        {
            if(ResultTable!=null)
            {
                ResultTable.Clear();
                ResultTable.Columns.Clear();
            }

            ResultTable = new DataTable();
            IDictionary<long,string> CatalogIDMaps = new Dictionary<long,string>();

            ResultTable.Columns.Add(new DataColumn("日期", typeof(string)));
            foreach (var item in new DailyPlanCatalogManageController().TravleAllEntities())
            {
                CatalogIDMaps.Add(item.ID,item.Name);
                ResultTable.Columns.Add(item.Name, typeof(object));
            }

            using (var db = GParam.Create().OpenDefalutDataBase())
            {
                DateTime currentDate = StartDate;
                
                while (currentDate.CompareTo(EndDate) <= 0)
                {
                    DataRow tempRow = ResultTable.NewRow();
                    IList<TB_DailyPlanSign> SignRecord = db.GetEntities<TB_DailyPlanSign>(TB_DailyPlanSignSet.SelectAll().Where(TB_DailyPlanSignSet.Date.Equal(currentDate.ToString("yyyy-MM-dd"))));
                    tempRow["日期"] = currentDate.ToString("yyyy年MM月dd日");
                    if(SignRecord != null && SignRecord.Count != 0)
                    {
                        foreach (var item in SignRecord)
                        {
                            if(Boolean.Parse(item.IsSign))
                            {
                                 tempRow[CatalogIDMaps[item.CatalogID]] = item;
                            }
                        }
                    }
                    currentDate = currentDate.AddDays(1);
                    ResultTable.Rows.Add(tempRow);
                }
            }
            return ResultTable;
        }
    }
}
