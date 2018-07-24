using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Sign.Model;
using Sign.Module_Sign.Controller;

namespace Sign.Module_Sign.Componet.Adapter
{
    public class TB_GYMAPPARATUSBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string BaseID = "BaseID";
        public readonly string CatalogID = "训练项目";
        public readonly string Weight = "负重";
        public readonly string Frequency = "每组个数";
        public readonly string GroupCount = "组数";
        public readonly string Op_Delete = "删除";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(BaseID);
            onCreateDataColumn(CatalogID);
            onCreateDataColumn(Weight);
            onCreateDataColumn(Frequency);
            onCreateDataColumn(GroupCount);
            onCreateDataColumn(Op_Delete);
        }
    }
    public class TB_GYMAPPARATUSAdapter : BaseGridControlAdapter3<TB_GYMAPPARATUS>
    {
        public override void onPrepareCreated(System.Data.DataTable m_ResultTable, BaseDataTableBuilder m_TableBuilder)
        {
            foreach (var item in new GYMCatalogManageController().TravleAllEntities())
                AddTempParams(""+item.ID, item.Name);
                
            
        }

        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_GYMAPPARATUS t)
        {
            TB_GYMAPPARATUSBuilder targetBuilder = builder as TB_GYMAPPARATUSBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.BaseID] = t.BaseID.ToString();
            tempRow[targetBuilder.CatalogID] = m_TempParams[t.CatalogID.ToString()];
            tempRow[targetBuilder.Weight] = t.Weight.ToString();
            tempRow[targetBuilder.Frequency] = t.Frequency.ToString();
            tempRow[targetBuilder.GroupCount] = t.GroupCount.ToString();
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
        }



        
    }
}
