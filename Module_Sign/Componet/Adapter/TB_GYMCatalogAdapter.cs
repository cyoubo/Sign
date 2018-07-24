using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Sign.Model;

namespace Sign.Module_Sign.Componet.Adapter
{
    public class TB_GYMCatalogBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string Name = "ÑµÁ·Ïî";
        public readonly string Description = "ÃèÊö";
        public readonly string Op_Delete = "É¾³ý";
        public readonly string Op_Edit = "±à¼­";

        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(Name);
            onCreateDataColumn(Description);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
        }
    }
    public class TB_GYMCatalogAdapter : BaseGridControlAdapter<TB_GYMCatalog>
    {
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_GYMCatalog t)
        {
            TB_GYMCatalogBuilder targetBuilder = builder as TB_GYMCatalogBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.Name] = t.Name;
            tempRow[targetBuilder.Description] = t.Description.ToString();
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
        }
    }
}
