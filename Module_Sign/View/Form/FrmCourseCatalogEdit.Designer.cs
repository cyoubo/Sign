namespace Sign.Module_Sign.View.Form
{
    partial class FrmCourseCatalogEdit
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
            this.gridControl_Catalog = new DevExpress.XtraGrid.GridControl();
            this.gridView_Catalog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Repo_HLE_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Repo_HLE_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.tv_Other = new DevExpress.XtraEditors.MemoEdit();
            this.btnE_Name = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Catalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Catalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Other.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnE_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_Catalog);
            this.layoutControl1.Controls.Add(this.tv_Other);
            this.layoutControl1.Controls.Add(this.btnE_Name);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(601, 548);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl_Catalog
            // 
            this.gridControl_Catalog.Location = new System.Drawing.Point(18, 219);
            this.gridControl_Catalog.MainView = this.gridView_Catalog;
            this.gridControl_Catalog.Name = "gridControl_Catalog";
            this.gridControl_Catalog.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Repo_HLE_Edit,
            this.Repo_HLE_Delete});
            this.gridControl_Catalog.Size = new System.Drawing.Size(565, 311);
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
            // tv_Other
            // 
            this.tv_Other.Location = new System.Drawing.Point(18, 79);
            this.tv_Other.Name = "tv_Other";
            this.tv_Other.Size = new System.Drawing.Size(565, 107);
            this.tv_Other.StyleController = this.layoutControl1;
            this.tv_Other.TabIndex = 5;
            // 
            // btnE_Name
            // 
            this.btnE_Name.Location = new System.Drawing.Point(95, 18);
            this.btnE_Name.Name = "btnE_Name";
            this.btnE_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.btnE_Name.Size = new System.Drawing.Size(488, 28);
            this.btnE_Name.StyleController = this.layoutControl1;
            this.btnE_Name.TabIndex = 4;
            this.btnE_Name.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnE_Name_ButtonClick);
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
            this.layoutControlItem1.Control = this.btnE_Name;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(571, 34);
            this.layoutControlItem1.Text = "类别名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tv_Other;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(571, 140);
            this.layoutControlItem2.Text = "备注";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl_Catalog;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 174);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(571, 344);
            this.layoutControlItem3.Text = "类别列表";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 22);
            // 
            // FrmCourseCatalogEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 548);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCourseCatalogEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "课程类别管理";
            this.Load += new System.EventHandler(this.FrmCourseCatalogEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Catalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Catalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Other.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnE_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.MemoEdit tv_Other;
        private DevExpress.XtraEditors.ButtonEdit btnE_Name;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridControl_Catalog;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Catalog;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Delete;
    }
}