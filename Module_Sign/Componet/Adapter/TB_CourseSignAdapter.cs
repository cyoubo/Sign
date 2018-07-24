using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Sign.Model;
using Sign.Module_Sign.Controller;

namespace Sign.Module_Sign.Componet.Adapter
{
    public class TB_CourseSignBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string CourseID = "CourseID";
        public readonly string CourseName = "课程名称";
        public readonly string SignDate = "上课时间";
        public readonly string Frequency = "上课次数";
        public readonly string Context = "上课内容";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(CourseID);
            onCreateDataColumn(CourseName);
            onCreateDataColumn(SignDate);
            onCreateDataColumn(Frequency);
            onCreateDataColumn(Context);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
        }
    }
    public class TB_CourseSignAdapter : BaseGridControlAdapter3<TB_CourseSign>
    {
        public override void onPrepareCreated(System.Data.DataTable m_ResultTable, BaseDataTableBuilder m_TableBuilder)
        {
            base.onPrepareCreated(m_ResultTable, m_TableBuilder);
            foreach (var item in new CourseManageController().TravleAllEntities())
            {
                AddTempParams("" + item.ID, item.Name);
            }
        }
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_CourseSign t)
        {
            TB_CourseSignBuilder targetBuilder = builder as TB_CourseSignBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.CourseID] = t.CourseID.ToString();
            tempRow[targetBuilder.SignDate] = t.SignDate;
            tempRow[targetBuilder.Frequency] = t.Frequency.ToString();
            tempRow[targetBuilder.Context] = t.Context;
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
            tempRow[targetBuilder.CourseName] = m_TempParams["" + t.CourseID];
        }
    }
}
