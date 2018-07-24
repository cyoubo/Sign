using System ;
using System.Collections.Generic ;
using System.Text ;
using System.Linq ;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Sign.Model;
using Sign.Module_Sign.Model.Const;
using Sign.Module_Sign.Controller;

namespace Sign.Module_Sign.Componet.Adapter
 {
	public class TB_CourseBuilder : BaseDataTableBuilder
	 {
		public readonly string ID = "ID";
		public readonly string Name = "课程名";
		public readonly string Description = "课程描述";
		public readonly string CatalogID = "课程类型";
		public readonly string SumFrequency = "课程总计次数";
		public readonly string StarDate = "课程开始日期";
		public readonly string EndDate = "课程截止日期";
		public readonly string State = "课程状态";
		public readonly string Op_Delete = "删除";
		public readonly string Op_Edit = "编辑";
        public readonly string Op_Stop = "状态编辑";
		protected override void AddDataColumn()
		 {
			onCreateDataColumn(ID);
			onCreateDataColumn(Name);
			onCreateDataColumn(Description);
			onCreateDataColumn(CatalogID);
			onCreateDataColumn(SumFrequency);
			onCreateDataColumn(StarDate);
			onCreateDataColumn(EndDate);
			onCreateDataColumn(State);
			onCreateDataColumn(Op_Delete);
			onCreateDataColumn(Op_Edit);
            onCreateDataColumn(Op_Stop);
		 }
	 }
	public class TB_CourseAdapter : BaseGridControlAdapter3<TB_Course>
	 {
        public override void onPrepareCreated(System.Data.DataTable m_ResultTable, BaseDataTableBuilder m_TableBuilder)
        {
            base.onPrepareCreated(m_ResultTable, m_TableBuilder);
            foreach (var item in new CourseCatalogManageController().TravleAllEntities())
            {
                AddTempParams("" + item.ID, item.Name);
            }
        }

		public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_Course t)
		 {
			TB_CourseBuilder targetBuilder = builder as TB_CourseBuilder;
			tempRow[targetBuilder.ID] = t.ID.ToString();
			tempRow[targetBuilder.Name] = t.Name;
			tempRow[targetBuilder.Description] = t.Description;
			tempRow[targetBuilder.CatalogID] = m_TempParams[t.CatalogID.ToString()];
			tempRow[targetBuilder.SumFrequency] = t.SumFrequency.ToString();
			tempRow[targetBuilder.StarDate] = t.StarDate;
			tempRow[targetBuilder.EndDate] = t.EndDate;
			tempRow[targetBuilder.State] = t.State;
			tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
			tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
            tempRow[targetBuilder.Op_Stop] = t.State.Equals(EnumCourseState.Done) ? "重新开始": "终止";
		 }
	 }
 }
