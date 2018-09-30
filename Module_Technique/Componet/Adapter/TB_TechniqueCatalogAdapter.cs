using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Technique.Model;

namespace Sign.Module_Technique.Componet.Adapter
{
    public class TB_TechniqueCatalogBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string Name = "Name";
        public readonly string Description = "Description";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(Name);
            onCreateDataColumn(Description);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
        }
    }
    public class TB_TechniqueCatalogAdapter : BaseGridControlAdapter<TB_TechniqueCatalog>
    {
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_TechniqueCatalog t)
        {
            TB_TechniqueCatalogBuilder targetBuilder = builder as TB_TechniqueCatalogBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.Name] = t.Name;
            tempRow[targetBuilder.Description] = t.Description;
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
        }
    }
}
