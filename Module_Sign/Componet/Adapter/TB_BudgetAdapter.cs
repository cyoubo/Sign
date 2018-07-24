using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Sign.Model;
using Sign.Module_Sign.Controller;

namespace Sign.Module_Sign.Componet.Adapter
{
    public class TB_BudgetBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string Name = "预算名称";
        public readonly string CatalogID = "CatalogID";
        public readonly string CatalogName = "预算类型";
        public readonly string Description = "预算描述";
        public readonly string SignDate = "打卡日期";
        public readonly string Estimate = "预计金额";
        public readonly string WeedDate = "除草日期";
        public readonly string Actuality = "除草金额";
        public readonly string DifferentReason = "差异原因";
        public readonly string Level = "种草强度";
        public readonly string State = "预算状态";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        public readonly string Op_Detail = "详情";

        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(Name);
            onCreateDataColumn(CatalogID);
            onCreateDataColumn(CatalogName);
            onCreateDataColumn(Description);
            onCreateDataColumn(SignDate);
            onCreateDataColumn(Estimate);
            onCreateDataColumn(WeedDate);
            onCreateDataColumn(Actuality);
            onCreateDataColumn(DifferentReason);
            onCreateDataColumn(Level);
            onCreateDataColumn(State);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
            onCreateDataColumn(Op_Detail);
        }
    }
    public class TB_BudgetAdapter : BaseGridControlAdapter3<TB_Budget>
    {
        public override void onPrepareCreated(System.Data.DataTable m_ResultTable, BaseDataTableBuilder m_TableBuilder)
        {
            base.onPrepareCreated(m_ResultTable, m_TableBuilder);
            foreach (var item in new BudgetCatalogManageController().TravleAllEntities())
            {
                AddTempParams("" + item.ID, item.Name);
            }
        }
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_Budget t)
        {
            TB_BudgetBuilder targetBuilder = builder as TB_BudgetBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.Name] = t.Name;
            tempRow[targetBuilder.CatalogID] = t.CatalogID.ToString();
            tempRow[targetBuilder.CatalogName] = m_TempParams[t.CatalogID.ToString()];
            tempRow[targetBuilder.Description] = t.Description;
            tempRow[targetBuilder.SignDate] = t.SignDate;
            tempRow[targetBuilder.Estimate] = t.Estimate.ToString();
            tempRow[targetBuilder.WeedDate] = t.WeedDate;
            tempRow[targetBuilder.Actuality] = t.Actuality.ToString();
            tempRow[targetBuilder.DifferentReason] = t.DifferentReason;
            tempRow[targetBuilder.Level] = t.Level.ToString();
            tempRow[targetBuilder.State] = t.State;
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
            tempRow[targetBuilder.Op_Detail] = targetBuilder.Op_Detail;
        }
    }
}
