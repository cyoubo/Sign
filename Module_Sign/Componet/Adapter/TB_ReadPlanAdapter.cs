using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Sign.Model;
using Sign.Module_Sign.Controller;
using Sign.Module_Sign.Model.Const;

namespace Sign.Module_Sign.Componet.Adapter
{
    public class TB_ReadPlanBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string BookName = "书名";
        public readonly string Author = "作者";
        public readonly string CreateDate = "创建日期";
        public readonly string StartDate = "开始阅读日期";
        public readonly string EndDate = "结束阅读时间";
        public readonly string Catalog = "读书类别ID";
        public readonly string CatalogName = "读书类别";
        public readonly string State = "阅读状态";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        public readonly string Op_Giveup = "状态编辑";

        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(BookName);
            onCreateDataColumn(Author);
            onCreateDataColumn(CreateDate);
            onCreateDataColumn(CatalogName);
            onCreateDataColumn(StartDate);
            onCreateDataColumn(EndDate);
            onCreateDataColumn(Catalog);
            onCreateDataColumn(State);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
            onCreateDataColumn(Op_Giveup);
        }
    }
    public class TB_ReadPlanAdapter : BaseGridControlAdapter3<TB_BookReadPlan>
    {
        public override void onFinishRowsCreated(System.Data.DataTable m_ResultTable)
        {
            base.onFinishRowsCreated(m_ResultTable);
            m_TempParams.Clear();
        }

        public override void onPrepareCreated(System.Data.DataTable m_ResultTable, BaseDataTableBuilder m_TableBuilder)
        {
            base.onPrepareCreated(m_ResultTable, m_TableBuilder);
            foreach (var item in new ReadCatalogManageController().TravleAllEntities())
                AddTempParams("" + item.ID, item.Name);
        }

        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_BookReadPlan t)
        {
            TB_ReadPlanBuilder targetBuilder = builder as TB_ReadPlanBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.BookName] = t.BookName;
            tempRow[targetBuilder.Author] = t.Author;
            tempRow[targetBuilder.CreateDate] = t.CreateDate;
            tempRow[targetBuilder.StartDate] = t.StartDate;
            tempRow[targetBuilder.EndDate] = t.EndDate;
            tempRow[targetBuilder.Catalog] = t.Catalog;
            tempRow[targetBuilder.CatalogName] = m_TempParams[""+t.Catalog];
            tempRow[targetBuilder.State] = t.State;
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
            if (t.State.Equals(EnumBookPlanState.Giveup))
                tempRow[targetBuilder.Op_Giveup] = "重新开始";
            if (t.State.Equals(EnumBookPlanState.Reading) || t.State.Equals(EnumBookPlanState.ToRead))
                tempRow[targetBuilder.Op_Giveup] = "放弃阅读";
        }

       
    }
}
