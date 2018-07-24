using System ;
using System.Collections.Generic ;
using System.Text ;
using System.Linq ;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Sign.Model;

namespace Sign.Module_Sign.Componet.Adapter
 {
	public class TB_BookCatalogBuilder : BaseDataTableBuilder
	 {
		public readonly string ID = "ID";
		public readonly string Name = "类型名称";
		public readonly string Op_Delete = "删除";
		public readonly string Op_Edit = "编辑";
		protected override void AddDataColumn()
		 {
			onCreateDataColumn(ID);
			onCreateDataColumn(Name);
			onCreateDataColumn(Op_Delete);
			onCreateDataColumn(Op_Edit);
		 }
	 }
	public class TB_BookCatalogAdapter : BaseGridControlAdapter<TB_BookCatalog>
	 {
		public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_BookCatalog t)
		 {
            TB_BookCatalogBuilder targetBuilder = builder as TB_BookCatalogBuilder;
			tempRow[targetBuilder.ID] = t.ID.ToString();
			tempRow[targetBuilder.Name] = t.Name;
			tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
			tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
		 }
	 }
 }
