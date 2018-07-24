namespace Sign.Module_Sign.View.Form
{
    partial class FrmBookCatalogEdit
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
            this.btn_Name = new DevExpress.XtraEditors.ButtonEdit();
            this.gridControl_BookCatalog = new DevExpress.XtraGrid.GridControl();
            this.gridView_BookCatalog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Repos_HLE_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Repos_HLE_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_BookCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_BookCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repos_HLE_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repos_HLE_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_Name);
            this.layoutControl1.Controls.Add(this.gridControl_BookCatalog);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(601, 548);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btn_Name
            // 
            this.btn_Name.Location = new System.Drawing.Point(95, 502);
            this.btn_Name.Name = "btn_Name";
            this.btn_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.btn_Name.Size = new System.Drawing.Size(488, 28);
            this.btn_Name.StyleController = this.layoutControl1;
            this.btn_Name.TabIndex = 7;
            this.btn_Name.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_Name_ButtonClick);
            // 
            // gridControl_BookCatalog
            // 
            this.gridControl_BookCatalog.Location = new System.Drawing.Point(18, 45);
            this.gridControl_BookCatalog.MainView = this.gridView_BookCatalog;
            this.gridControl_BookCatalog.Name = "gridControl_BookCatalog";
            this.gridControl_BookCatalog.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Repos_HLE_Delete,
            this.Repos_HLE_Edit});
            this.gridControl_BookCatalog.Size = new System.Drawing.Size(565, 451);
            this.gridControl_BookCatalog.TabIndex = 4;
            this.gridControl_BookCatalog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_BookCatalog});
            // 
            // gridView_BookCatalog
            // 
            this.gridView_BookCatalog.GridControl = this.gridControl_BookCatalog;
            this.gridView_BookCatalog.Name = "gridView_BookCatalog";
            this.gridView_BookCatalog.OptionsView.ShowGroupPanel = false;
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
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(601, 548);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl_BookCatalog;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(571, 484);
            this.layoutControlItem1.Text = "书籍类型";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_Name;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 484);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(571, 34);
            this.layoutControlItem4.Text = "类型名称";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 22);
            // 
            // FrmBookCatalogEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 548);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmBookCatalogEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "书籍类型编辑";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBookCatalogEdit_FormClosed);
            this.Load += new System.EventHandler(this.FrmBookCatalogEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_BookCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_BookCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repos_HLE_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repos_HLE_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl_BookCatalog;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_BookCatalog;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repos_HLE_Delete;
        private DevExpress.XtraEditors.ButtonEdit btn_Name;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repos_HLE_Edit;
    }
}