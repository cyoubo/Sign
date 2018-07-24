namespace Sign.Module_Sign.View.Form
{
    partial class FrmGYMCatalogEdit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl_gymcatalog = new DevExpress.XtraGrid.GridControl();
            this.gridView_gymcatalog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Repos_HLE_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Repos_HLE_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.tv_Des = new DevExpress.XtraEditors.MemoEdit();
            this.btn_Name = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_gymcatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_gymcatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repos_HLE_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repos_HLE_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Des.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_gymcatalog);
            this.layoutControl1.Controls.Add(this.tv_Des);
            this.layoutControl1.Controls.Add(this.btn_Name);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(601, 548);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl_gymcatalog
            // 
            this.gridControl_gymcatalog.Location = new System.Drawing.Point(18, 194);
            this.gridControl_gymcatalog.MainView = this.gridView_gymcatalog;
            this.gridControl_gymcatalog.Name = "gridControl_gymcatalog";
            this.gridControl_gymcatalog.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Repos_HLE_Delete,
            this.Repos_HLE_Edit});
            this.gridControl_gymcatalog.Size = new System.Drawing.Size(565, 336);
            this.gridControl_gymcatalog.TabIndex = 6;
            this.gridControl_gymcatalog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_gymcatalog});
            // 
            // gridView_gymcatalog
            // 
            this.gridView_gymcatalog.GridControl = this.gridControl_gymcatalog;
            this.gridView_gymcatalog.Name = "gridView_gymcatalog";
            this.gridView_gymcatalog.OptionsView.ShowGroupPanel = false;
            // 
            // Repos_HLE_Delete
            // 
            this.Repos_HLE_Delete.AutoHeight = false;
            this.Repos_HLE_Delete.Name = "Repos_HLE_Delete";
            this.Repos_HLE_Delete.Click += new System.EventHandler(this.Repos_HLE_Delete_Click);
            // 
            // Repos_HLE_Edit
            // 
            this.Repos_HLE_Edit.AutoHeight = false;
            this.Repos_HLE_Edit.Name = "Repos_HLE_Edit";
            this.Repos_HLE_Edit.Click += new System.EventHandler(this.Repos_HLE_Edit_Click);
            // 
            // tv_Des
            // 
            this.tv_Des.Location = new System.Drawing.Point(18, 79);
            this.tv_Des.Name = "tv_Des";
            this.tv_Des.Size = new System.Drawing.Size(565, 82);
            this.tv_Des.StyleController = this.layoutControl1;
            this.tv_Des.TabIndex = 5;
            // 
            // btn_Name
            // 
            this.btn_Name.Location = new System.Drawing.Point(95, 18);
            this.btn_Name.Name = "btn_Name";
            this.btn_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.btn_Name.Size = new System.Drawing.Size(488, 28);
            this.btn_Name.StyleController = this.layoutControl1;
            this.btn_Name.TabIndex = 4;
            this.btn_Name.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_Name_ButtonClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(601, 548);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btn_Name;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(571, 34);
            this.layoutControlItem1.Text = "锻炼项目";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tv_Des;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(571, 115);
            this.layoutControlItem2.Text = "项目描述";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl_gymcatalog;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 149);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(571, 369);
            this.layoutControlItem3.Text = "项目列表";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 22);
            // 
            // FrmGYMCatalogEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 548);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmGYMCatalogEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "健身项目管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGYMCatalogEdit_FormClosed);
            this.Load += new System.EventHandler(this.FrmGYMCatalogEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_gymcatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_gymcatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repos_HLE_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repos_HLE_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Des.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.ButtonEdit btn_Name;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.MemoEdit tv_Des;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridControl_gymcatalog;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_gymcatalog;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repos_HLE_Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repos_HLE_Edit;

    }
}