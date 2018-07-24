using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Sign.Model;
using Sign.Module_Sign.Controller;
using System.Data;
using Sign.Module_Sign.Model.Const;

namespace Sign.Module_Sign.Componet.Adapter
{
    public class TB_DailyPlanSignBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string Date = "日期";
        public readonly string CatalogID = "任务项";
        public readonly string Completion = "完成程度";
        public readonly string Other = "说明";
        public readonly string IsSign = "是否打卡";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";

        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(Date);
            onCreateDataColumn(CatalogID);
            onCreateDataColumn(Completion);
            onCreateDataColumn(Other);
            onCreateDataColumn(IsSign);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
        }
    }

    public class TB_DailyPlanSignAdapter : BaseGridControlAdapter3<TB_DailyPlanSign>
    {
        public override void onPrepareCreated(System.Data.DataTable m_ResultTable, BaseDataTableBuilder m_TableBuilder)
        {
            base.onPrepareCreated(m_ResultTable, m_TableBuilder);
            foreach (var item in new DailyPlanCatalogManageController().TravleAllEntities())
            {
                AddTempParams("" + item.ID, item.Name);
            }
        }

        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_DailyPlanSign t)
        {
            TB_DailyPlanSignBuilder targetBuilder = builder as TB_DailyPlanSignBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.Date] = t.Date;
            tempRow[targetBuilder.CatalogID] = base.m_TempParams[t.CatalogID.ToString()];
            tempRow[targetBuilder.Completion] = t.Completion;
            tempRow[targetBuilder.Other] = t.Other;
            tempRow[targetBuilder.IsSign] = t.IsSign;
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
        }
    }

    public class TB_DailyPlanSignEditBuilder : BaseDataTableBuilder
    {
        public readonly string IsSign = "是否打卡";
        public readonly string CatalogID = "项目类别ID";
        public readonly string CatalogName = "项目类别";
        public readonly string Completion = "完成度";
        public readonly string Other = "备注";
        public readonly string Type ="消极/积极性";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(IsSign, typeof(object));
            onCreateDataColumn(CatalogID);
            onCreateDataColumn(CatalogName);
            onCreateDataColumn(Completion);
            onCreateDataColumn(Type);
            onCreateDataColumn(Other);

        }

        public DataTable CreateDefalutCatalogItemTable()
        {
            DataTable table = CreateDataTable();
            foreach (var item in new DailyPlanCatalogManageController().TravleAllEntities())
            {
                DataRow temp = table.NewRow();
                temp[this.IsSign] = false;
                temp[this.CatalogID] = item.ID;
                temp[this.CatalogName] = item.Name;
                if (item.Type.Equals("消极"))
                    temp[this.Completion] = EnumDailyPlanState.Worse;
                else
                    temp[this.Completion] = EnumDailyPlanState.Well_Done;
                temp[this.Type]=item.Type;
                table.Rows.Add(temp);
            }
            return table;
        }

        public IList<TB_DailyPlanSign> ExtractEntries(DataTable dataTable)
        {
            IList<TB_DailyPlanSign> result = new List<TB_DailyPlanSign>();
            foreach (DataRow row in dataTable.Rows)
            {
                //if (Boolean.Parse(row[this.IsSign].ToString()))
                {
                    TB_DailyPlanSign temp = new TB_DailyPlanSign();
                    temp.IsSign = (row[this.IsSign].ToString());
                    temp.Other = row[this.Other].ToString();
                    temp.Completion = row[this.Completion].ToString();
                    temp.CatalogID = long.Parse(row[this.CatalogID].ToString());
                    result.Add(temp);
                }
            }
            return result;
        }
    }
}
