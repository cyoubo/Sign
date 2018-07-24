namespace Sign.Module_Sign.View.Form
{
    partial class FrmDailyPlanCatalogEdit
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
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tv_Other = new DevExpress.XtraEditors.TextEdit();
            this.gridControl_dailyscan = new DevExpress.XtraGrid.GridControl();
            this.gridView_dailyscan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Repo_HLE_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Repo_HLE_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.btn_Sure = new DevExpress.XtraEditors.SimpleButton();
            this.tv_Name = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Other.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_dailyscan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_dailyscan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.comboBoxEdit1);
            this.layoutControl1.Controls.Add(this.tv_Other);
            this.layoutControl1.Controls.Add(this.gridControl_dailyscan);
            this.layoutControl1.Controls.Add(this.btn_Sure);
            this.layoutControl1.Controls.Add(this.tv_Name);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(601, 548);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "积极";
            this.comboBoxEdit1.Location = new System.Drawing.Point(410, 45);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "积极",
            "消极",
            "中性"});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(173, 28);
            this.comboBoxEdit1.StyleController = this.layoutControl1;
            this.comboBoxEdit1.TabIndex = 10;
            // 
            // tv_Other
            // 
            this.tv_Other.Location = new System.Drawing.Point(131, 79);
            this.tv_Other.Name = "tv_Other";
            this.tv_Other.Size = new System.Drawing.Size(397, 28);
            this.tv_Other.StyleController = this.layoutControl1;
            this.tv_Other.TabIndex = 9;
            // 
            // gridControl_dailyscan
            // 
            this.gridControl_dailyscan.Location = new System.Drawing.Point(18, 144);
            this.gridControl_dailyscan.MainView = this.gridView_dailyscan;
            this.gridControl_dailyscan.Name = "gridControl_dailyscan";
            this.gridControl_dailyscan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Repo_HLE_Edit,
            this.Repo_HLE_Delete});
            this.gridControl_dailyscan.Size = new System.Drawing.Size(565, 386);
            this.gridControl_dailyscan.TabIndex = 8;
            this.gridControl_dailyscan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_dailyscan});
            // 
            // gridView_dailyscan
            // 
            this.gridView_dailyscan.GridControl = this.gridControl_dailyscan;
            this.gridView_dailyscan.Name = "gridView_dailyscan";
            this.gridView_dailyscan.OptionsView.ShowGroupPanel = false;
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
            // btn_Sure
            // 
            this.btn_Sure.Location = new System.Drawing.Point(534, 79);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(49, 32);
            this.btn_Sure.StyleController = this.layoutControl1;
            this.btn_Sure.TabIndex = 7;
            this.btn_Sure.Text = "确定";
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // tv_Name
            // 
            this.tv_Name.Location = new System.Drawing.Point(18, 45);
            this.tv_Name.Name = "tv_Name";
            this.tv_Name.Size = new System.Drawing.Size(386, 28);
            this.tv_Name.StyleController = this.layoutControl1;
            this.tv_Name.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(601, 548);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tv_Name;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(392, 61);
            this.layoutControlItem1.Text = "日常项目名";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_Sure;
            this.layoutControlItem4.Location = new System.Drawing.Point(516, 61);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(55, 38);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl_dailyscan;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 99);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(571, 419);
            this.layoutControlItem5.Text = "日常项目列表";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tv_Other;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(516, 38);
            this.layoutControlItem3.Text = "项目描述";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.comboBoxEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(392, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(179, 61);
            this.layoutControlItem2.Text = "积极/消极性";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(108, 22);
            // 
            // FrmDailyPlanCatalogEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 548);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDailyPlanCatalogEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日常项目管理";
            this.Load += new System.EventHandler(this.FrmDailyPlanCatalogEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Other.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_dailyscan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_dailyscan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit tv_Name;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl_dailyscan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_dailyscan;
        private DevExpress.XtraEditors.SimpleButton btn_Sure;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit tv_Other;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Delete;
    }
}