using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Sign.Model;
using Sign.Module_Sign.Controller;

namespace Sign.Module_Sign.Componet.Adapter
{
    public class TB_BookReadSignBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string Date = "打卡日期";
        public readonly string ReadPlanID = "阅读计划编号";
        public readonly string Other = "备注";
        public readonly string BookName = "书名";
        public readonly string Op_Edit = "编辑";
        public readonly string Op_Delete = "删除";

        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(Date);
            onCreateDataColumn(ReadPlanID);
            onCreateDataColumn(BookName);
            onCreateDataColumn(Other);
            onCreateDataColumn(Op_Edit);
            onCreateDataColumn(Op_Delete);
        }
    }

    public class TB_BookReadSignAdapter : BaseGridControlAdapter3<TB_BookReadSign>
    {
        public override void onPrepareCreated(System.Data.DataTable m_ResultTable, BaseDataTableBuilder m_TableBuilder)
        {
            base.onPrepareCreated(m_ResultTable, m_TableBuilder);
            foreach (var item in new ReadPlanManageController().TravleAllEntities())
                AddTempParams("" + item.ID, item.BookName); 
        }

        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_BookReadSign t)
        {
            TB_BookReadSignBuilder targetBuilder = builder as TB_BookReadSignBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.Date] = t.Date;
            tempRow[targetBuilder.ReadPlanID] = t.ReadPlanID.ToString();
            tempRow[targetBuilder.Other] = t.Other;
            tempRow[targetBuilder.BookName] = m_TempParams[t.ReadPlanID.ToString()];
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
        }
    }

    public class TB_BookReadSignDeserializion : BaseTableDeserializion<TB_BookReadSign>
    {
        public override TB_BookReadSign onDesrialize(BaseDataTableBuilder builder, System.Data.DataRow row, params object[] otherP)
        {
            TB_BookReadSignBuilder targetBuilder = builder as TB_BookReadSignBuilder;
            TB_BookReadSign tempBean = new TB_BookReadSign();
            tempBean.ID = long.Parse(row[targetBuilder.ID].ToString());
            tempBean.Date = row[targetBuilder.Date].ToString();
            tempBean.ReadPlanID = long.Parse(row[targetBuilder.ReadPlanID].ToString());
            tempBean.Other = row[targetBuilder.Other].ToString();
            return tempBean;
        }
    }
}
