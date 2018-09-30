namespace Sign.Module_Technique.View.UControl
{
    partial class UC_TechniqueCatalogEdit
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
            this.btn_sure = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_Catalog = new DevExpress.XtraGrid.GridControl();
            this.gridView_Catalog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repo_HLE_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repo_HLE_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.tv_Description = new DevExpress.XtraEditors.TextEdit();
            this.tv_Name = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Catalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Catalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_sure);
            this.layoutControl1.Controls.Add(this.gridControl_Catalog);
            this.layoutControl1.Controls.Add(this.tv_Description);
            this.layoutControl1.Controls.Add(this.tv_Name);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1266, 793);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(1160, 67);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(69, 32);
            this.btn_sure.StyleController = this.layoutControl1;
            this.btn_sure.TabIndex = 7;
            this.btn_sure.Text = "确定";
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // gridControl_Catalog
            // 
            this.gridControl_Catalog.Location = new System.Drawing.Point(37, 173);
            this.gridControl_Catalog.MainView = this.gridView_Catalog;
            this.gridControl_Catalog.Name = "gridControl_Catalog";
            this.gridControl_Catalog.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repo_HLE_Edit,
            this.repo_HLE_Delete});
            this.gridControl_Catalog.Size = new System.Drawing.Size(1192, 583);
            this.gridControl_Catalog.TabIndex = 6;
            this.gridControl_Catalog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Catalog});
            // 
            // gridView_Catalog
            // 
            this.gridView_Catalog.GridControl = this.gridControl_Catalog;
            this.gridView_Catalog.Name = "gridView_Catalog";
            this.gridView_Catalog.OptionsView.ShowGroupPanel = false;
            // 
            // repo_HLE_Edit
            // 
            this.repo_HLE_Edit.AutoHeight = false;
            this.repo_HLE_Edit.Name = "repo_HLE_Edit";
            this.repo_HLE_Edit.Click += new System.EventHandler(this.repo_HLE_Edit_Click);
            // 
            // repo_HLE_Delete
            // 
            this.repo_HLE_Delete.AutoHeight = false;
            this.repo_HLE_Delete.Name = "repo_HLE_Delete";
            this.repo_HLE_Delete.Click += new System.EventHandler(this.repo_HLE_Delete_Click);
            // 
            // tv_Description
            // 
            this.tv_Description.Location = new System.Drawing.Point(451, 67);
            this.tv_Description.Name = "tv_Description";
            this.tv_Description.Size = new System.Drawing.Size(703, 28);
            this.tv_Description.StyleController = this.layoutControl1;
            this.tv_Description.TabIndex = 5;
            // 
            // tv_Name
            // 
            this.tv_Name.Location = new System.Drawing.Point(114, 67);
            this.tv_Name.Name = "tv_Name";
            this.tv_Name.Size = new System.Drawing.Size(254, 28);
            this.tv_Name.StyleController = this.layoutControl1;
            this.tv_Name.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1266, 793);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1236, 106);
            this.layoutControlGroup2.Text = "类别信息";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tv_Name;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(337, 38);
            this.layoutControlItem1.Text = "类别名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tv_Description;
            this.layoutControlItem2.Location = new System.Drawing.Point(337, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(786, 38);
            this.layoutControlItem2.Text = "类别描述";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_sure;
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(1123, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(75, 38);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(75, 38);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(75, 38);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            this.layoutControlItem4.TrimClientAreaToControl = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 106);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup3.Size = new System.Drawing.Size(1236, 657);
            this.layoutControlGroup3.Text = "类别列表";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl_Catalog;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1198, 589);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // UC_TechniqueCatalogEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_TechniqueCatalogEdit";
            this.Size = new System.Drawing.Size(1266, 793);
            this.Load += new System.EventHandler(this.UC_TechniqueCatalogEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Catalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Catalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btn_sure;
        private DevExpress.XtraGrid.GridControl gridControl_Catalog;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Catalog;
        private DevExpress.XtraEditors.TextEdit tv_Description;
        private DevExpress.XtraEditors.TextEdit tv_Name;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repo_HLE_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repo_HLE_Delete;
    }
}
