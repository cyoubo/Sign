namespace Sign.Module_Sign.View.UControl
{
    partial class UC_CourseSignEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CourseSignEdit));
            this.gridControl_Course = new DevExpress.XtraGrid.GridControl();
            this.gridView_Course = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tv_Context = new DevExpress.XtraEditors.MemoEdit();
            this.btn_Sure = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_CourseName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateE_Date = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Context.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CourseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_Course
            // 
            this.gridControl_Course.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Course.Location = new System.Drawing.Point(13, 43);
            this.gridControl_Course.MainView = this.gridView_Course;
            this.gridControl_Course.Name = "gridControl_Course";
            this.gridControl_Course.Padding = new System.Windows.Forms.Padding(10);
            this.gridControl_Course.Size = new System.Drawing.Size(618, 625);
            this.gridControl_Course.TabIndex = 8;
            this.gridControl_Course.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Course});
            // 
            // gridView_Course
            // 
            this.gridView_Course.GridControl = this.gridControl_Course;
            this.gridView_Course.Name = "gridView_Course";
            this.gridView_Course.OptionsView.ShowGroupPanel = false;
            // 
            // tv_Context
            // 
            this.tv_Context.Location = new System.Drawing.Point(18, 430);
            this.tv_Context.Name = "tv_Context";
            this.tv_Context.Size = new System.Drawing.Size(396, 195);
            this.tv_Context.StyleController = this.layoutControl2;
            this.tv_Context.TabIndex = 7;
            // 
            // btn_Sure
            // 
            this.btn_Sure.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sure.Image")));
            this.btn_Sure.Location = new System.Drawing.Point(340, 631);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(74, 32);
            this.btn_Sure.StyleController = this.layoutControl2;
            this.btn_Sure.TabIndex = 6;
            this.btn_Sure.Text = "确定";
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // cmb_CourseName
            // 
            this.cmb_CourseName.Location = new System.Drawing.Point(18, 45);
            this.cmb_CourseName.Name = "cmb_CourseName";
            this.cmb_CourseName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_CourseName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_CourseName.Size = new System.Drawing.Size(396, 28);
            this.cmb_CourseName.StyleController = this.layoutControl2;
            this.cmb_CourseName.TabIndex = 5;
            this.cmb_CourseName.SelectedIndexChanged += new System.EventHandler(this.cmb_CourseName_SelectedIndexChanged);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1084, 681);
            this.splitContainerControl1.SplitterPosition = 432;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.dateE_Date);
            this.layoutControl2.Controls.Add(this.btn_Sure);
            this.layoutControl2.Controls.Add(this.tv_Context);
            this.layoutControl2.Controls.Add(this.cmb_CourseName);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(432, 681);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup2.Size = new System.Drawing.Size(432, 681);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmb_CourseName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(402, 61);
            this.layoutControlItem2.Text = "课程名称";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 22);
            // 
            // dateE_Date
            // 
            this.dateE_Date.AutoSize = false;
            this.dateE_Date.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Date.Location = new System.Drawing.Point(18, 79);
            this.dateE_Date.Name = "dateE_Date";
            this.dateE_Date.ShowMonthHeaders = false;
            this.dateE_Date.Size = new System.Drawing.Size(396, 318);
            this.dateE_Date.StyleController = this.layoutControl2;
            this.dateE_Date.TabIndex = 6;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dateE_Date;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(402, 324);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tv_Context;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 385);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(402, 228);
            this.layoutControlItem4.Text = "课程内容";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_Sure;
            this.layoutControlItem3.FillControlToClientArea = false;
            this.layoutControlItem3.Location = new System.Drawing.Point(322, 613);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(80, 38);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            this.layoutControlItem3.TrimClientAreaToControl = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl_Course);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(10);
            this.groupControl1.Size = new System.Drawing.Size(644, 681);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "上课记录";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 613);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(322, 38);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // UC_CourseSignEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UC_CourseSignEdit";
            this.Size = new System.Drawing.Size(1084, 681);
            this.Load += new System.EventHandler(this.UC_CourseSignEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Context.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CourseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmb_CourseName;
        private DevExpress.XtraEditors.MemoEdit tv_Context;
        private DevExpress.XtraEditors.SimpleButton btn_Sure;
        private DevExpress.XtraGrid.GridControl gridControl_Course;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Course;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.Controls.CalendarControl dateE_Date;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;

    }
}
