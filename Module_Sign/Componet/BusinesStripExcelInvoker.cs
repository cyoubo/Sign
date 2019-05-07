using PS.Plot.FrameBasic.Module_SupportLibs.AsposeExcel.Component;
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
    public class BusinesStripExcelInvoker
    {
        public string FilePath { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartDate { get; set; }

        public IList<TB_DailyPlanCatalog> CatalogItems { get; set; }

        public void AppendDailyCatalog(TB_DailyPlanCatalog item)
        {
            if (CatalogItems == null)
                CatalogItems = new List<TB_DailyPlanCatalog>();
            if(item!=null)
                CatalogItems.Add(item);
        }

        public bool Export()
        {
            bool result = false;
            ExcelHelper helper = new ExcelHelper(FilePath);
            if (helper.StartEdit(0) == false)
            {
                GParam.Create().WriteSystemLog(helper.ErrorMessage);
                return result;
            }

            try
            {
                DataTable exportDt = new DataTable();
                exportDt.Columns.Add("日期", typeof(string));
                foreach (TB_DailyPlanCatalog item in CatalogItems)
                {
                    DataColumn col = new DataColumn();
                    col.ColumnName = item.Name;
                    col.Caption = item.Name;
                    exportDt.Columns.Add(col);
                }

                while (StartDate.CompareTo(EndDate) <= 0)
                {
                    DataRow temprow = exportDt.NewRow();
                    temprow[0] = StartDate.ToString("yyyy-MM-dd");
                    exportDt.Rows.Add(temprow);
                    StartDate = StartDate.AddDays(1);
                }
                helper.InsertDataTable(exportDt);
                result = helper.Save();
            }
            catch (Exception ex)
            {
                GParam.Create().WriteSystemLog("Export",ex);
            }
            return result;
        }
    }
}
