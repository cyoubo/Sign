namespace Sign.Module_Sign.View.UControl
{
    partial class UC_ReadPlanEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ReadPlanEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl_ReadPlan = new DevExpress.XtraGrid.GridControl();
            this.gridView_ReadPlan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Repo_HLE_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Repo_HLE_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Repo_HLE_GiveupOrRestart = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.cmb_Catalog = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_Sure = new DevExpress.XtraEditors.SimpleButton();
            this.dateE_Sign = new DevExpress.XtraEditors.DateEdit();
            this.tv_Author = new DevExpress.XtraEditors.TextEdit();
            this.tv_BookName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ReadPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ReadPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_GiveupOrRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Catalog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Sign.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Sign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Author.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_BookName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_ReadPlan);
            this.layoutControl1.Controls.Add(this.cmb_Catalog);
            this.layoutControl1.Controls.Add(this.btn_Sure);
            this.layoutControl1.Controls.Add(this.dateE_Sign);
            this.layoutControl1.Controls.Add(this.tv_Author);
            this.layoutControl1.Controls.Add(this.tv_BookName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1016, 688);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl_ReadPlan
            // 
            this.gridControl_ReadPlan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.gridControl_ReadPlan.Location = new System.Drawing.Point(18, 181);
            this.gridControl_ReadPlan.MainView = this.gridView_ReadPlan;
            this.gridControl_ReadPlan.Name = "gridControl_ReadPlan";
            this.gridControl_ReadPlan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Repo_HLE_Edit,
            this.Repo_HLE_Delete,
            this.Repo_HLE_GiveupOrRestart});
            this.gridControl_ReadPlan.Size = new System.Drawing.Size(980, 489);
            this.gridControl_ReadPlan.TabIndex = 16;
            this.gridControl_ReadPlan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ReadPlan});
            // 
            // gridView_ReadPlan
            // 
            this.gridView_ReadPlan.GridControl = this.gridControl_ReadPlan;
            this.gridView_ReadPlan.Name = "gridView_ReadPlan";
            this.gridView_ReadPlan.OptionsView.ShowGroupPanel = false;
            // 
            // Repo_HLE_Edit
            // 
            this.Repo_HLE_Edit.AutoHeight = false;
            this.Repo_HLE_Edit.Name = "Repo_HLE_Edit";
            this.Repo_HLE_Edit.Click += new System.EventHandler(this.Repo_HLE_Edit_Click);
            // 
            // Repo_HLE_Delete
            // 
            this.Repo_HLE_Delete.AutoHeight = false;
            this.Repo_HLE_Delete.Name = "Repo_HLE_Delete";
            this.Repo_HLE_Delete.Click += new System.EventHandler(this.Repo_HLE_Delete_Click);
            // 
            // Repo_HLE_GiveupOrRestart
            // 
            this.Repo_HLE_GiveupOrRestart.AutoHeight = false;
            this.Repo_HLE_GiveupOrRestart.Name = "Repo_HLE_GiveupOrRestart";
            this.Repo_HLE_GiveupOrRestart.Click += new System.EventHandler(this.Repo_HLE_GiveupOrRestart_Click);
            // 
            // cmb_Catalog
            // 
            this.cmb_Catalog.Location = new System.Drawing.Point(525, 94);
            this.cmb_Catalog.Name = "cmb_Catalog";
            this.cmb_Catalog.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Catalog.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_Catalog.Size = new System.Drawing.Size(214, 28);
            this.cmb_Catalog.StyleController = this.layoutControl1;
            this.cmb_Catalog.TabIndex = 15;
            // 
            // btn_Sure
            // 
            this.btn_Sure.Location = new System.Drawing.Point(913, 90);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(66, 32);
            this.btn_Sure.StyleController = this.layoutControl1;
            this.btn_Sure.TabIndex = 12;
            this.btn_Sure.Text = "确定";
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // dateE_Sign
            // 
            this.dateE_Sign.EditValue = null;
            this.dateE_Sign.Location = new System.Drawing.Point(745, 94);
            this.dateE_Sign.Name = "dateE_Sign";
            this.dateE_Sign.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Sign.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Sign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateE_Sign.Size = new System.Drawing.Size(162, 28);
            this.dateE_Sign.StyleController = this.layoutControl1;
            this.dateE_Sign.TabIndex = 8;
            // 
            // tv_Author
            // 
            this.tv_Author.Location = new System.Drawing.Point(314, 94);
            this.tv_Author.Name = "tv_Author";
            this.tv_Author.Size = new System.Drawing.Size(205, 28);
            this.tv_Author.StyleController = this.layoutControl1;
            this.tv_Author.TabIndex = 5;
            // 
            // tv_BookName
            // 
            this.tv_BookName.Location = new System.Drawing.Point(37, 94);
            this.tv_BookName.Name = "tv_BookName";
            this.tv_BookName.Size = new System.Drawing.Size(271, 28);
            this.tv_BookName.StyleController = this.layoutControl1;
            this.tv_BookName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1016, 688);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.BestFitWeight = 20;
            this.layoutControlItem1.Control = this.tv_BookName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(277, 61);
            this.layoutControlItem1.Text = "书名";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gridControl_ReadPlan;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 129);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 10, 3);
            this.layoutControlItem7.Size = new System.Drawing.Size(986, 529);
            this.layoutControlItem7.Text = "阅读计划";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.BestFitWeight = 20;
            this.layoutControlItem2.Control = this.tv_Author;
            this.layoutControlItem2.Location = new System.Drawing.Point(277, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(211, 61);
            this.layoutControlItem2.Text = "作者";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.BestFitWeight = 20;
            this.layoutControlItem3.Control = this.cmb_Catalog;
            this.layoutControlItem3.Location = new System.Drawing.Point(488, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(220, 61);
            this.layoutControlItem3.Text = "书籍类型";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.BestFitWeight = 20;
            this.layoutControlItem5.Control = this.dateE_Sign;
            this.layoutControlItem5.Location = new System.Drawing.Point(708, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(168, 61);
            this.layoutControlItem5.Text = "登记时间";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btn_Sure;
            this.layoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.layoutControlItem9.FillControlToClientArea = false;
            this.layoutControlItem9.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem9.Image")));
            this.layoutControlItem9.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.layoutControlItem9.Location = new System.Drawing.Point(876, 0);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(72, 38);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(72, 38);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(72, 61);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            this.layoutControlItem9.TrimClientAreaToControl = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem9});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup2.Size = new System.Drawing.Size(986, 129);
            this.layoutControlGroup2.Text = "书籍详情";
            // 
            // UC_ReadPlanEdit
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_ReadPlanEdit";
            this.Size = new System.Drawing.Size(1016, 688);
            this.Load += new System.EventHandler(this.UC_ReadPlanEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ReadPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ReadPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_GiveupOrRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Catalog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Sign.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Sign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Author.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_BookName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btn_Sure;
        private DevExpress.XtraEditors.DateEdit dateE_Sign;
        private DevExpress.XtraEditors.TextEdit tv_Author;
        private DevExpress.XtraEditors.TextEdit tv_BookName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Catalog;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gridControl_ReadPlan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ReadPlan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_GiveupOrRestart;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    }
}
