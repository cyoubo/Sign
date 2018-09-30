using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Technique.Model;

namespace Sign.Module_Technique.Componet.Adapter
{
    public class TB_TechniqueBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string Name = "Name";
        public readonly string CatalogID = "CatalogID";
        public readonly string Description = "Description";
        public readonly string Status = "Status";
        public readonly string CreateDate = "CreateDate";
        public readonly string StartDate = "StartDate";
        public readonly string PauseDate = "PauseDate";
        public readonly string FinishDate = "FinishDate";
        public readonly string AbandonDate = "AbandonDate";
        public readonly string Interest = "Interest";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        public readonly string Op_Detail = "详情";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(Name);
            onCreateDataColumn(CatalogID);
            onCreateDataColumn(Description);
            onCreateDataColumn(Status);
            onCreateDataColumn(CreateDate);
            onCreateDataColumn(StartDate);
            onCreateDataColumn(PauseDate);
            onCreateDataColumn(FinishDate);
            onCreateDataColumn(AbandonDate);
            onCreateDataColumn(Interest);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
            onCreateDataColumn(Op_Detail);
        }
    }
    public class TB_TechniqueAdapter : BaseGridControlAdapter<TB_Technique>
    {
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_Technique t)
        {
            TB_TechniqueBuilder targetBuilder = builder as TB_TechniqueBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.Name] = t.Name;
            tempRow[targetBuilder.CatalogID] = t.CatalogID.ToString();
            tempRow[targetBuilder.Description] = t.Description;
            tempRow[targetBuilder.Status] = t.Status;
            tempRow[targetBuilder.CreateDate] = t.CreateDate;
            tempRow[targetBuilder.StartDate] = t.StartDate;
            tempRow[targetBuilder.PauseDate] = t.PauseDate;
            tempRow[targetBuilder.FinishDate] = t.FinishDate;
            tempRow[targetBuilder.AbandonDate] = t.AbandonDate;
            tempRow[targetBuilder.Interest] = t.Interest.ToString();
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
            tempRow[targetBuilder.Op_Detail] = targetBuilder.Op_Detail;
        }
    }
}
