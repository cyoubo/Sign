namespace Sign.Module_Sign.View.UControl
{
    partial class UC_CourseEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CourseEdit));
            this.btn_Sure = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_Course = new DevExpress.XtraGrid.GridControl();
            this.gridView_Course = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Repo_HLE_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Repo_HLE_Update = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Repo_HLE_Stop = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.tv_SumFrequency = new DevExpress.XtraEditors.TextEdit();
            this.cmb_Catalog = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tv_Description = new DevExpress.XtraEditors.MemoEdit();
            this.tv_Name = new DevExpress.XtraEditors.TextEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateE_Start = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_SumFrequency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Catalog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Start.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sure
            // 
            this.btn_Sure.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sure.Image")));
            this.btn_Sure.Location = new System.Drawing.Point(362, 754);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(74, 32);
            this.btn_Sure.StyleController = this.layoutControl2;
            this.btn_Sure.TabIndex = 11;
            this.btn_Sure.Text = "确定";
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // gridControl_Course
            // 
            this.gridControl_Course.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Course.Location = new System.Drawing.Point(13, 43);
            this.gridControl_Course.MainView = this.gridView_Course;
            this.gridControl_Course.Name = "gridControl_Course";
            this.gridControl_Course.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Repo_HLE_Delete,
            this.Repo_HLE_Update,
            this.Repo_HLE_Stop});
            this.gridControl_Course.Size = new System.Drawing.Size(833, 748);
            this.gridControl_Course.TabIndex = 10;
            this.gridControl_Course.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Course});
            // 
            // gridView_Course
            // 
            this.gridView_Course.GridControl = this.gridControl_Course;
            this.gridView_Course.Name = "gridView_Course";
            this.gridView_Course.OptionsView.ShowGroupPanel = false;
            // 
            // Repo_HLE_Delete
            // 
            this.Repo_HLE_Delete.AutoHeight = false;
            this.Repo_HLE_Delete.Name = "Repo_HLE_Delete";
            this.Repo_HLE_Delete.Click += new System.EventHandler(this.Repo_HLE_Delete_Click);
            // 
            // Repo_HLE_Update
            // 
            this.Repo_HLE_Update.AutoHeight = false;
            this.Repo_HLE_Update.Name = "Repo_HLE_Update";
            this.Repo_HLE_Update.Click += new System.EventHandler(this.Repo_HLE_Update_Click);
            // 
            // Repo_HLE_Stop
            // 
            this.Repo_HLE_Stop.AutoHeight = false;
            this.Repo_HLE_Stop.Name = "Repo_HLE_Stop";
            this.Repo_HLE_Stop.Click += new System.EventHandler(this.Repo_HLE_Stop_Click);
            // 
            // tv_SumFrequency
            // 
            this.tv_SumFrequency.Location = new System.Drawing.Point(96, 437);
            this.tv_SumFrequency.Name = "tv_SumFrequency";
            this.tv_SumFrequency.Properties.Mask.EditMask = "n0";
            this.tv_SumFrequency.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tv_SumFrequency.Size = new System.Drawing.Size(340, 28);
            this.tv_SumFrequency.StyleController = this.layoutControl2;
            this.tv_SumFrequency.TabIndex = 7;
            // 
            // cmb_Catalog
            // 
            this.cmb_Catalog.Location = new System.Drawing.Point(96, 52);
            this.cmb_Catalog.Name = "cmb_Catalog";
            this.cmb_Catalog.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Catalog.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_Catalog.Size = new System.Drawing.Size(340, 28);
            this.cmb_Catalog.StyleController = this.layoutControl2;
            this.cmb_Catalog.TabIndex = 6;
            // 
            // tv_Description
            // 
            this.tv_Description.Location = new System.Drawing.Point(18, 499);
            this.tv_Description.Name = "tv_Description";
            this.tv_Description.Size = new System.Drawing.Size(418, 249);
            this.tv_Description.StyleController = this.layoutControl2;
            this.tv_Description.TabIndex = 5;
            // 
            // tv_Name
            // 
            this.tv_Name.Location = new System.Drawing.Point(96, 18);
            this.tv_Name.Name = "tv_Name";
            this.tv_Name.Size = new System.Drawing.Size(340, 28);
            this.tv_Name.StyleController = this.layoutControl2;
            this.tv_Name.TabIndex = 4;
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1321, 804);
            this.splitContainerControl1.SplitterPosition = 454;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.dateE_Start);
            this.layoutControl2.Controls.Add(this.btn_Sure);
            this.layoutControl2.Controls.Add(this.tv_Name);
            this.layoutControl2.Controls.Add(this.cmb_Catalog);
            this.layoutControl2.Controls.Add(this.tv_Description);
            this.layoutControl2.Controls.Add(this.tv_SumFrequency);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup3;
            this.layoutControl2.Size = new System.Drawing.Size(454, 804);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem8,
            this.emptySpaceItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup3.Size = new System.Drawing.Size(454, 804);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tv_Name;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(424, 34);
            this.layoutControlItem1.Text = "课程名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmb_Catalog;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(424, 34);
            this.layoutControlItem3.Text = "课程类别";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 22);
            // 
            // dateE_Start
            // 
            this.dateE_Start.AutoSize = false;
            this.dateE_Start.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Start.Location = new System.Drawing.Point(18, 113);
            this.dateE_Start.Name = "dateE_Start";
            this.dateE_Start.ShowMonthHeaders = false;
            this.dateE_Start.Size = new System.Drawing.Size(418, 318);
            this.dateE_Start.StyleController = this.layoutControl2;
            this.dateE_Start.TabIndex = 7;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dateE_Start;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(424, 351);
            this.layoutControlItem6.Text = "开始日期";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tv_SumFrequency;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 419);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(424, 34);
            this.layoutControlItem4.Text = "总计次数";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tv_Description;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 453);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(424, 283);
            this.layoutControlItem2.Text = "课程描述";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btn_Sure;
            this.layoutControlItem8.FillControlToClientArea = false;
            this.layoutControlItem8.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem8.Image")));
            this.layoutControlItem8.Location = new System.Drawing.Point(344, 736);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(80, 38);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            this.layoutControlItem8.TrimClientAreaToControl = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 736);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(344, 38);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl_Course);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(10);
            this.groupControl1.Size = new System.Drawing.Size(859, 804);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "课程列表";
            // 
            // UC_CourseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UC_CourseEdit";
            this.Size = new System.Drawing.Size(1321, 804);
            this.Load += new System.EventHandler(this.UC_CourseEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_SumFrequency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Catalog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Start.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit tv_Description;
        private DevExpress.XtraEditors.TextEdit tv_Name;
        private DevExpress.XtraGrid.GridControl gridControl_Course;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Course;
        private DevExpress.XtraEditors.TextEdit tv_SumFrequency;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Catalog;
        private DevExpress.XtraEditors.SimpleButton btn_Sure;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Update;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Stop;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.Controls.CalendarControl dateE_Start;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
