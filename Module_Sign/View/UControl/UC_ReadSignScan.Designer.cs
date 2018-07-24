namespace Sign.Module_Sign.View.UControl
{
    partial class UC_ReadSignScan
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl_ReadPlan = new DevExpress.XtraGrid.GridControl();
            this.gridView_ReadPlan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.tv_Other = new DevExpress.XtraEditors.TextEdit();
            this.dateE_Sign = new DevExpress.XtraEditors.DateEdit();
            this.gridControl_ReadSign = new DevExpress.XtraGrid.GridControl();
            this.gridView_ReadSign = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Repo_HLE_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Repo_HLE_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ReadPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ReadPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Other.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Sign.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Sign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ReadSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ReadSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl_ReadPlan);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1541, 816);
            this.splitContainerControl1.SplitterPosition = 457;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl_ReadPlan
            // 
            this.gridControl_ReadPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ReadPlan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControl_ReadPlan.Location = new System.Drawing.Point(0, 0);
            this.gridControl_ReadPlan.MainView = this.gridView_ReadPlan;
            this.gridControl_ReadPlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControl_ReadPlan.Name = "gridControl_ReadPlan";
            this.gridControl_ReadPlan.Size = new System.Drawing.Size(457, 816);
            this.gridControl_ReadPlan.TabIndex = 0;
            this.gridControl_ReadPlan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ReadPlan});
            // 
            // gridView_ReadPlan
            // 
            this.gridView_ReadPlan.GridControl = this.gridControl_ReadPlan;
            this.gridView_ReadPlan.Name = "gridView_ReadPlan";
            this.gridView_ReadPlan.OptionsView.ShowGroupPanel = false;
            this.gridView_ReadPlan.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_ReadPlan_RowClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_update);
            this.layoutControl1.Controls.Add(this.tv_Other);
            this.layoutControl1.Controls.Add(this.dateE_Sign);
            this.layoutControl1.Controls.Add(this.gridControl_ReadSign);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1076, 816);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(992, 18);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(66, 32);
            this.btn_update.StyleController = this.layoutControl1;
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "修改";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tv_Other
            // 
            this.tv_Other.Location = new System.Drawing.Point(579, 18);
            this.tv_Other.Name = "tv_Other";
            this.tv_Other.Size = new System.Drawing.Size(407, 28);
            this.tv_Other.StyleController = this.layoutControl1;
            this.tv_Other.TabIndex = 6;
            // 
            // dateE_Sign
            // 
            this.dateE_Sign.EditValue = null;
            this.dateE_Sign.Location = new System.Drawing.Point(93, 18);
            this.dateE_Sign.Name = "dateE_Sign";
            this.dateE_Sign.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Sign.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Sign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateE_Sign.Size = new System.Drawing.Size(405, 28);
            this.dateE_Sign.StyleController = this.layoutControl1;
            this.dateE_Sign.TabIndex = 5;
            // 
            // gridControl_ReadSign
            // 
            this.gridControl_ReadSign.Location = new System.Drawing.Point(18, 81);
            this.gridControl_ReadSign.MainView = this.gridView_ReadSign;
            this.gridControl_ReadSign.Name = "gridControl_ReadSign";
            this.gridControl_ReadSign.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Repo_HLE_Edit,
            this.Repo_HLE_Delete});
            this.gridControl_ReadSign.Size = new System.Drawing.Size(1040, 717);
            this.gridControl_ReadSign.TabIndex = 4;
            this.gridControl_ReadSign.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ReadSign});
            // 
            // gridView_ReadSign
            // 
            this.gridView_ReadSign.GridControl = this.gridControl_ReadSign;
            this.gridView_ReadSign.Name = "gridView_ReadSign";
            this.gridView_ReadSign.OptionsView.ShowGroupPanel = false;
            // 
            // Repo_HLE_Edit
            // 
            this.Repo_HLE_Edit.AutoHeight = false;
            this.Repo_HLE_Edit.Name = "Repo_HLE_Edit";
            this.Repo_HLE_Edit.Click += new System.EventHandler(this.Repo_HLE_Edit_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1076, 816);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl_ReadSign;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1046, 748);
            this.layoutControlItem1.Text = "阅读记录";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateE_Sign;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(486, 38);
            this.layoutControlItem2.Text = "打卡日期";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tv_Other;
            this.layoutControlItem3.Location = new System.Drawing.Point(486, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(488, 38);
            this.layoutControlItem3.Text = "备注";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_update;
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem4.Location = new System.Drawing.Point(974, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(72, 38);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(72, 38);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(72, 38);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            this.layoutControlItem4.TrimClientAreaToControl = false;
            // 
            // Repo_HLE_Delete
            // 
            this.Repo_HLE_Delete.AutoHeight = false;
            this.Repo_HLE_Delete.Name = "Repo_HLE_Delete";
            this.Repo_HLE_Delete.Click += new System.EventHandler(this.Repo_HLE_Delete_Click);
            // 
            // UC_ReadSignScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UC_ReadSignScan";
            this.Size = new System.Drawing.Size(1541, 816);
            this.Load += new System.EventHandler(this.UC_ReadSignScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ReadPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ReadPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tv_Other.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Sign.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Sign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ReadSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ReadSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl_ReadPlan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ReadPlan;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl_ReadSign;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ReadSign;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.TextEdit tv_Other;
        private DevExpress.XtraEditors.DateEdit dateE_Sign;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Delete;


    }
}
