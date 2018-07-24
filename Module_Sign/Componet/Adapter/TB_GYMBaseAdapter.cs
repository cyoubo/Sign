using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Sign.Model;

namespace Sign.Module_Sign.Componet.Adapter
{
    public class TB_GYMBaseBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string Date = "打卡日期";
        public readonly string Calorie = "运动量";
        public readonly string Other = "备注";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(Date);
            onCreateDataColumn(Calorie);
            onCreateDataColumn(Other);
        }
    }
    public class TB_GYMBaseAdapter : BaseGridControlAdapter<TB_GYMBase>
    {
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_GYMBase t)
        {
            TB_GYMBaseBuilder targetBuilder = builder as TB_GYMBaseBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.Date] = t.Date;
            tempRow[targetBuilder.Calorie] = t.Calorie;
            tempRow[targetBuilder.Other] = t.Other;
        }
    }
}
