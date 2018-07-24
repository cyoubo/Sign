using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Sign.Module_Sign.Model;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;

namespace Sign.Module_Sign.Componet.Adapter
{
    public class TB_CourseCatalogBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string Name = "名称";
        public readonly string Other = "描述";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(Name);
            onCreateDataColumn(Other);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
        }
    }
    public class TB_CourseCatalogAdapter : BaseGridControlAdapter<TB_CourseCatalog>
    {
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_CourseCatalog t)
        {
            TB_CourseCatalogBuilder targetBuilder = builder as TB_CourseCatalogBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.Name] = t.Name;
            tempRow[targetBuilder.Other] = t.Other;
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
        }
    }
}
