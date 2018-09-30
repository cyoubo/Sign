using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Technique.Model;

namespace Sign.Module_Technique.Componet.Adapter
{
    public class TB_TechniqueRegisterBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string TechniqueID = "TechniqueID";
        public readonly string TechniqueStatue = "TechniqueStatue";
        public readonly string Reason = "Reason";
        public readonly string Summary = "Summary";
        public readonly string Introspection = "Introspection";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(TechniqueID);
            onCreateDataColumn(TechniqueStatue);
            onCreateDataColumn(Reason);
            onCreateDataColumn(Summary);
            onCreateDataColumn(Introspection);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
        }
    }
    public class TB_TechniqueRegisterAdapter : BaseGridControlAdapter<TB_TechniqueRegister>
    {
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_TechniqueRegister t)
        {
            TB_TechniqueRegisterBuilder targetBuilder = builder as TB_TechniqueRegisterBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.TechniqueID] = t.TechniqueID.ToString();
            tempRow[targetBuilder.TechniqueStatue] = t.TechniqueStatue.ToString();
            tempRow[targetBuilder.Reason] = t.Reason;
            tempRow[targetBuilder.Summary] = t.Summary;
            tempRow[targetBuilder.Introspection] = t.Introspection;
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
        }
    }
}
