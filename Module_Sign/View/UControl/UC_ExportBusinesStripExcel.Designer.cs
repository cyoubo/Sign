namespace Sign.Module_Sign.View.UControl
{
    partial class UC_ExportBusinesStripExcel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dateE_Start = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateE_End = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.checkList_Catalog = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_pickAll = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_pickNo = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_pickRevser = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnE_Export = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_sure = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkList_Catalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnE_Export.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_sure);
            this.layoutControl1.Controls.Add(this.btnE_Export);
            this.layoutControl1.Controls.Add(this.btn_pickRevser);
            this.layoutControl1.Controls.Add(this.btn_pickNo);
            this.layoutControl1.Controls.Add(this.btn_pickAll);
            this.layoutControl1.Controls.Add(this.checkList_Catalog);
            this.layoutControl1.Controls.Add(this.dateE_End);
            this.layoutControl1.Controls.Add(this.dateE_Start);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(723, 437);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(723, 437);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // dateE_Start
            // 
            this.dateE_Start.EditValue = null;
            this.dateE_Start.Location = new System.Drawing.Point(64, 12);
            this.dateE_Start.Name = "dateE_Start";
            this.dateE_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Start.Size = new System.Drawing.Size(290, 20);
            this.dateE_Start.StyleController = this.layoutControl1;
            this.dateE_Start.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateE_Start;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(346, 24);
            this.layoutControlItem1.Text = "起始日期";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // dateE_End
            // 
            this.dateE_End.EditValue = null;
            this.dateE_End.Location = new System.Drawing.Point(410, 12);
            this.dateE_End.Name = "dateE_End";
            this.dateE_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_End.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_End.Size = new System.Drawing.Size(301, 20);
            this.dateE_End.StyleController = this.layoutControl1;
            this.dateE_End.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateE_End;
            this.layoutControlItem2.Location = new System.Drawing.Point(346, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(357, 24);
            this.layoutControlItem2.Text = "终止日期";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // checkList_Catalog
            // 
            this.checkList_Catalog.Location = new System.Drawing.Point(12, 36);
            this.checkList_Catalog.Name = "checkList_Catalog";
            this.checkList_Catalog.Size = new System.Drawing.Size(699, 337);
            this.checkList_Catalog.StyleController = this.layoutControl1;
            this.checkList_Catalog.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.checkList_Catalog;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(703, 341);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // btn_pickAll
            // 
            this.btn_pickAll.Location = new System.Drawing.Point(475, 377);
            this.btn_pickAll.Name = "btn_pickAll";
            this.btn_pickAll.Size = new System.Drawing.Size(76, 22);
            this.btn_pickAll.StyleController = this.layoutControl1;
            this.btn_pickAll.TabIndex = 7;
            this.btn_pickAll.Text = "全选";
            this.btn_pickAll.Click += new System.EventHandler(this.btn_pickAll_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_pickAll;
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(463, 365);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            this.layoutControlItem4.TrimClientAreaToControl = false;
            // 
            // btn_pickNo
            // 
            this.btn_pickNo.Location = new System.Drawing.Point(555, 377);
            this.btn_pickNo.Name = "btn_pickNo";
            this.btn_pickNo.Size = new System.Drawing.Size(76, 22);
            this.btn_pickNo.StyleController = this.layoutControl1;
            this.btn_pickNo.TabIndex = 8;
            this.btn_pickNo.Text = "全不选";
            this.btn_pickNo.Click += new System.EventHandler(this.btn_pickNo_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btn_pickNo;
            this.layoutControlItem5.FillControlToClientArea = false;
            this.layoutControlItem5.Location = new System.Drawing.Point(543, 365);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            this.layoutControlItem5.TrimClientAreaToControl = false;
            // 
            // btn_pickRevser
            // 
            this.btn_pickRevser.Location = new System.Drawing.Point(635, 377);
            this.btn_pickRevser.Name = "btn_pickRevser";
            this.btn_pickRevser.Size = new System.Drawing.Size(76, 22);
            this.btn_pickRevser.StyleController = this.layoutControl1;
            this.btn_pickRevser.TabIndex = 9;
            this.btn_pickRevser.Text = "反选";
            this.btn_pickRevser.Click += new System.EventHandler(this.btn_pickRevser_Click);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btn_pickRevser;
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(623, 365);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            this.layoutControlItem6.TrimClientAreaToControl = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 365);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(463, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnE_Export
            // 
            this.btnE_Export.Location = new System.Drawing.Point(64, 403);
            this.btnE_Export.Name = "btnE_Export";
            this.btnE_Export.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnE_Export.Size = new System.Drawing.Size(567, 20);
            this.btnE_Export.StyleController = this.layoutControl1;
            this.btnE_Export.TabIndex = 10;
            this.btnE_Export.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnE_Export_ButtonClick);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnE_Export;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 391);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(623, 26);
            this.layoutControlItem7.Text = "输出路径";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(48, 14);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(635, 403);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(76, 22);
            this.btn_sure.StyleController = this.layoutControl1;
            this.btn_sure.TabIndex = 11;
            this.btn_sure.Text = "输出";
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btn_sure;
            this.layoutControlItem8.FillControlToClientArea = false;
            this.layoutControlItem8.Location = new System.Drawing.Point(623, 391);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(80, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            this.layoutControlItem8.TrimClientAreaToControl = false;
            // 
            // UC_ExportBusinesStripExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_ExportBusinesStripExcel";
            this.Size = new System.Drawing.Size(723, 437);
            this.Load += new System.EventHandler(this.UC_ExportBusinesStripExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkList_Catalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnE_Export.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit dateE_End;
        private DevExpress.XtraEditors.DateEdit dateE_Start;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.CheckedListBoxControl checkList_Catalog;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btn_pickRevser;
        private DevExpress.XtraEditors.SimpleButton btn_pickNo;
        private DevExpress.XtraEditors.SimpleButton btn_pickAll;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.ButtonEdit btnE_Export;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btn_sure;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}
