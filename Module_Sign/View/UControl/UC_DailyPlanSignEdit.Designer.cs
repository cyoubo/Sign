namespace Sign.Module_Sign.View.UControl
{
    partial class UC_DailyPlanSignEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DailyPlanSignEdit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Btn_Sure = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_Sign = new DevExpress.XtraGrid.GridControl();
            this.gridView_Sign = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repo_CKE_IsSign = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repo_Combox_Completion = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Sign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Sign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_CKE_IsSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_Combox_Completion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Btn_Sure);
            this.layoutControl1.Controls.Add(this.gridControl_Sign);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(4084, 351, 680, 525);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(772, 440);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Btn_Sure
            // 
            this.Btn_Sure.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sure.Image")));
            this.Btn_Sure.Location = new System.Drawing.Point(674, 29);
            this.Btn_Sure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Sure.Name = "Btn_Sure";
            this.Btn_Sure.Size = new System.Drawing.Size(86, 22);
            this.Btn_Sure.StyleController = this.layoutControl1;
            this.Btn_Sure.TabIndex = 7;
            this.Btn_Sure.Text = "打卡";
            this.Btn_Sure.Click += new System.EventHandler(this.Btn_Sure_Click);
            // 
            // gridControl_Sign
            // 
            this.gridControl_Sign.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gridControl_Sign.Location = new System.Drawing.Point(13, 87);
            this.gridControl_Sign.MainView = this.gridView_Sign;
            this.gridControl_Sign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl_Sign.Name = "gridControl_Sign";
            this.gridControl_Sign.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repo_CKE_IsSign,
            this.repo_Combox_Completion});
            this.gridControl_Sign.Size = new System.Drawing.Size(746, 340);
            this.gridControl_Sign.TabIndex = 5;
            this.gridControl_Sign.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Sign});
            // 
            // gridView_Sign
            // 
            this.gridView_Sign.GridControl = this.gridControl_Sign;
            this.gridView_Sign.Name = "gridView_Sign";
            this.gridView_Sign.OptionsView.ShowGroupPanel = false;
            this.gridView_Sign.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView_Sign_InitNewRow);
            // 
            // repo_CKE_IsSign
            // 
            this.repo_CKE_IsSign.AutoHeight = false;
            this.repo_CKE_IsSign.Name = "repo_CKE_IsSign";
            // 
            // repo_Combox_Completion
            // 
            this.repo_Combox_Completion.AutoHeight = false;
            this.repo_Combox_Completion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repo_Combox_Completion.Items.AddRange(new object[] {
            "满意",
            "基本满意",
            "还需努力",
            "有点糟糕",
            "糟糕透顶"});
            this.repo_Combox_Completion.Name = "repo_Combox_Completion";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(12, 31);
            this.dateEdit1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit1.Size = new System.Drawing.Size(658, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(772, 440);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(662, 43);
            this.layoutControlItem1.Text = "打卡日期";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl_Sign;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 43);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 15, 3);
            this.layoutControlItem2.Size = new System.Drawing.Size(752, 377);
            this.layoutControlItem2.Text = "打卡内容";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Btn_Sure;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(662, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(90, 38);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(90, 38);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(90, 43);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            this.layoutControlItem4.TrimClientAreaToControl = false;
            // 
            // UC_DailyPlanSignEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_DailyPlanSignEdit";
            this.Size = new System.Drawing.Size(772, 440);
            this.Load += new System.EventHandler(this.UC_DailyPlanSign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Sign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Sign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_CKE_IsSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_Combox_Completion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl_Sign;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Sign;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repo_CKE_IsSign;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repo_Combox_Completion;
        private DevExpress.XtraEditors.SimpleButton Btn_Sure;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
