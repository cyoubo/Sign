namespace Sign.Module_Sign.View.UControl
{
    partial class UC_GYMSignScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GYMSignScan));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl_signscan = new DevExpress.XtraGrid.GridControl();
            this.gridView_signscan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.dateE_Date = new DevExpress.XtraEditors.DateEdit();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_appScan = new DevExpress.XtraGrid.GridControl();
            this.gridView_appScan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Repo_HLE_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.tv_Other = new DevExpress.XtraEditors.TextEdit();
            this.tv_Calorie = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_signscan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_signscan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_appScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_appScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Other.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Calorie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl_signscan);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1334, 739);
            this.splitContainerControl1.SplitterPosition = 407;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl_signscan
            // 
            this.gridControl_signscan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_signscan.Location = new System.Drawing.Point(0, 0);
            this.gridControl_signscan.MainView = this.gridView_signscan;
            this.gridControl_signscan.Name = "gridControl_signscan";
            this.gridControl_signscan.Size = new System.Drawing.Size(407, 739);
            this.gridControl_signscan.TabIndex = 0;
            this.gridControl_signscan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_signscan});
            // 
            // gridView_signscan
            // 
            this.gridView_signscan.GridControl = this.gridControl_signscan;
            this.gridView_signscan.Name = "gridView_signscan";
            this.gridView_signscan.OptionsView.ShowGroupPanel = false;
            this.gridView_signscan.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_signscan_RowCellClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_Update);
            this.layoutControl1.Controls.Add(this.dateE_Date);
            this.layoutControl1.Controls.Add(this.btn_Delete);
            this.layoutControl1.Controls.Add(this.gridControl_appScan);
            this.layoutControl1.Controls.Add(this.tv_Other);
            this.layoutControl1.Controls.Add(this.tv_Calorie);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(919, 739);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btn_Update
            // 
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.Location = new System.Drawing.Point(797, 64);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(85, 32);
            this.btn_Update.StyleController = this.layoutControl1;
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "修改当日";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dateE_Date
            // 
            this.dateE_Date.EditValue = null;
            this.dateE_Date.Location = new System.Drawing.Point(132, 67);
            this.dateE_Date.Name = "dateE_Date";
            this.dateE_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Date.Size = new System.Drawing.Size(568, 28);
            this.dateE_Date.StyleController = this.layoutControl1;
            this.dateE_Date.TabIndex = 9;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(706, 64);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(85, 32);
            this.btn_Delete.StyleController = this.layoutControl1;
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "删除当日";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // gridControl_appScan
            // 
            this.gridControl_appScan.Location = new System.Drawing.Point(18, 202);
            this.gridControl_appScan.MainView = this.gridView_appScan;
            this.gridControl_appScan.Name = "gridControl_appScan";
            this.gridControl_appScan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Repo_HLE_Delete});
            this.gridControl_appScan.Size = new System.Drawing.Size(883, 519);
            this.gridControl_appScan.TabIndex = 7;
            this.gridControl_appScan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_appScan});
            // 
            // gridView_appScan
            // 
            this.gridView_appScan.GridControl = this.gridControl_appScan;
            this.gridView_appScan.Name = "gridView_appScan";
            this.gridView_appScan.OptionsView.ShowGroupPanel = false;
            // 
            // Repo_HLE_Delete
            // 
            this.Repo_HLE_Delete.AutoHeight = false;
            this.Repo_HLE_Delete.Name = "Repo_HLE_Delete";
            this.Repo_HLE_Delete.Click += new System.EventHandler(this.Repo_HLE_Delete_Click);
            // 
            // tv_Other
            // 
            this.tv_Other.Location = new System.Drawing.Point(393, 108);
            this.tv_Other.Name = "tv_Other";
            this.tv_Other.Size = new System.Drawing.Size(489, 28);
            this.tv_Other.StyleController = this.layoutControl1;
            this.tv_Other.TabIndex = 6;
            // 
            // tv_Calorie
            // 
            this.tv_Calorie.Location = new System.Drawing.Point(132, 108);
            this.tv_Calorie.Name = "tv_Calorie";
            this.tv_Calorie.Size = new System.Drawing.Size(160, 28);
            this.tv_Calorie.StyleController = this.layoutControl1;
            this.tv_Calorie.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(919, 739);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tv_Calorie;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(261, 48);
            this.layoutControlItem2.Text = "有氧活动量";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tv_Other;
            this.layoutControlItem3.Location = new System.Drawing.Point(261, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(590, 48);
            this.layoutControlItem3.Text = "备注信息";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl_appScan;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 150);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 10, 3);
            this.layoutControlItem4.Size = new System.Drawing.Size(889, 559);
            this.layoutControlItem4.Text = "器械锻炼";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btn_Delete;
            this.layoutControlItem5.FillControlToClientArea = false;
            this.layoutControlItem5.Location = new System.Drawing.Point(669, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(91, 32);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(91, 32);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 0, 0);
            this.layoutControlItem5.Size = new System.Drawing.Size(91, 34);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = " ";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            this.layoutControlItem5.TrimClientAreaToControl = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateE_Date;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(669, 34);
            this.layoutControlItem1.Text = "打卡日期";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btn_Update;
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(760, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(91, 32);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(91, 32);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 0, 0);
            this.layoutControlItem6.Size = new System.Drawing.Size(91, 34);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            this.layoutControlItem6.TrimClientAreaToControl = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup2.Size = new System.Drawing.Size(889, 150);
            this.layoutControlGroup2.Text = "基础信息";
            // 
            // UC_GYMSignScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UC_GYMSignScan";
            this.Size = new System.Drawing.Size(1334, 739);
            this.Load += new System.EventHandler(this.UC_GYMSignScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_signscan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_signscan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_appScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_appScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Other.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Calorie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl_signscan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_signscan;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl_appScan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_appScan;
        private DevExpress.XtraEditors.TextEdit tv_Other;
        private DevExpress.XtraEditors.TextEdit tv_Calorie;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.DateEdit dateE_Date;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Delete;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;

    }
}
