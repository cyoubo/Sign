using System ;
using System.Collections.Generic ;
using System.Text ;
using System.Linq ;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Sign.Model;

namespace Sign.Module_Sign.Componet.Adapter
 {
	public class TB_SpecialDailyBuilder : BaseDataTableBuilder
	 {
		public readonly string ID = "ID";
		public readonly string Type = "Type";
		public readonly string StartDate = "StartDate";
		public readonly string EndDate = "EndDate";
		public readonly string Place = "Place";
		public readonly string Other = "Other";
		public readonly string Color = "Color";
		public readonly string Op_Delete = "删除";
		public readonly string Op_Edit = "编辑";
		protected override void AddDataColumn()
		 {
			onCreateDataColumn(ID);
			onCreateDataColumn(Type);
			onCreateDataColumn(StartDate);
			onCreateDataColumn(EndDate);
			onCreateDataColumn(Place);
			onCreateDataColumn(Other);
			onCreateDataColumn(Color);
			onCreateDataColumn(Op_Delete);
			onCreateDataColumn(Op_Edit);
		 }
	 }
	public class TB_SpecialDailyAdapter : BaseGridControlAdapter<TB_SpecialDaily>
	 {
		public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_SpecialDaily t)
		 {
			TB_SpecialDailyBuilder targetBuilder = builder as TB_SpecialDailyBuilder;
			tempRow[targetBuilder.ID] = t.ID.ToString();
			tempRow[targetBuilder.Type] = t.Type;
			tempRow[targetBuilder.StartDate] = t.StartDate;
			tempRow[targetBuilder.EndDate] = t.EndDate;
			tempRow[targetBuilder.Place] = t.Place;
			tempRow[targetBuilder.Other] = t.Other;
			tempRow[targetBuilder.Color] = t.Color;
			tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
			tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
		 }
	 }
 }
