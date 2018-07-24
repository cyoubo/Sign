namespace Sign.Module_Sign.View.UControl
{
    partial class UC_SpecialDailyEdit
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
            this.btn_Sure = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_specialDaily = new DevExpress.XtraGrid.GridControl();
            this.gridView_specialDaily = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Repo_HLE_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Repo_HLE_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.colorEdit_Color = new DevExpress.XtraEditors.ColorEdit();
            this.tv_Other = new DevExpress.XtraEditors.TextEdit();
            this.tv_Place = new DevExpress.XtraEditors.TextEdit();
            this.dateE_End = new DevExpress.XtraEditors.DateEdit();
            this.dateE_Start = new DevExpress.XtraEditors.DateEdit();
            this.tv_Type = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_specialDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_specialDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit_Color.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Other.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Place.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_Sure);
            this.layoutControl1.Controls.Add(this.gridControl_specialDaily);
            this.layoutControl1.Controls.Add(this.colorEdit_Color);
            this.layoutControl1.Controls.Add(this.tv_Other);
            this.layoutControl1.Controls.Add(this.tv_Place);
            this.layoutControl1.Controls.Add(this.dateE_End);
            this.layoutControl1.Controls.Add(this.dateE_Start);
            this.layoutControl1.Controls.Add(this.tv_Type);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1256, 763);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btn_Sure
            // 
            this.btn_Sure.Location = new System.Drawing.Point(1153, 101);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(66, 32);
            this.btn_Sure.StyleController = this.layoutControl1;
            this.btn_Sure.TabIndex = 11;
            this.btn_Sure.Text = "确定";
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // gridControl_specialDaily
            // 
            this.gridControl_specialDaily.Location = new System.Drawing.Point(18, 185);
            this.gridControl_specialDaily.MainView = this.gridView_specialDaily;
            this.gridControl_specialDaily.Name = "gridControl_specialDaily";
            this.gridControl_specialDaily.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Repo_HLE_Edit,
            this.Repo_HLE_Delete});
            this.gridControl_specialDaily.Size = new System.Drawing.Size(1220, 560);
            this.gridControl_specialDaily.TabIndex = 10;
            this.gridControl_specialDaily.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_specialDaily});
            // 
            // gridView_specialDaily
            // 
            this.gridView_specialDaily.GridControl = this.gridControl_specialDaily;
            this.gridView_specialDaily.Name = "gridView_specialDaily";
            this.gridView_specialDaily.OptionsView.ShowGroupPanel = false;
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
            // colorEdit_Color
            // 
            this.colorEdit_Color.EditValue = System.Drawing.Color.Empty;
            this.colorEdit_Color.Location = new System.Drawing.Point(889, 101);
            this.colorEdit_Color.Name = "colorEdit_Color";
            this.colorEdit_Color.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEdit_Color.Size = new System.Drawing.Size(258, 28);
            this.colorEdit_Color.StyleController = this.layoutControl1;
            this.colorEdit_Color.TabIndex = 9;
            // 
            // tv_Other
            // 
            this.tv_Other.Location = new System.Drawing.Point(490, 101);
            this.tv_Other.Name = "tv_Other";
            this.tv_Other.Size = new System.Drawing.Size(280, 28);
            this.tv_Other.StyleController = this.layoutControl1;
            this.tv_Other.TabIndex = 8;
            // 
            // tv_Place
            // 
            this.tv_Place.Location = new System.Drawing.Point(150, 101);
            this.tv_Place.Name = "tv_Place";
            this.tv_Place.Size = new System.Drawing.Size(221, 28);
            this.tv_Place.StyleController = this.layoutControl1;
            this.tv_Place.TabIndex = 7;
            // 
            // dateE_End
            // 
            this.dateE_End.EditValue = null;
            this.dateE_End.Location = new System.Drawing.Point(889, 67);
            this.dateE_End.Name = "dateE_End";
            this.dateE_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_End.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_End.Size = new System.Drawing.Size(330, 28);
            this.dateE_End.StyleController = this.layoutControl1;
            this.dateE_End.TabIndex = 6;
            // 
            // dateE_Start
            // 
            this.dateE_Start.EditValue = null;
            this.dateE_Start.Location = new System.Drawing.Point(490, 67);
            this.dateE_Start.Name = "dateE_Start";
            this.dateE_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Start.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateE_Start.Size = new System.Drawing.Size(280, 28);
            this.dateE_Start.StyleController = this.layoutControl1;
            this.dateE_Start.TabIndex = 5;
            // 
            // tv_Type
            // 
            this.tv_Type.Location = new System.Drawing.Point(150, 67);
            this.tv_Type.Name = "tv_Type";
            this.tv_Type.Properties.ReadOnly = true;
            this.tv_Type.Size = new System.Drawing.Size(221, 28);
            this.tv_Type.StyleController = this.layoutControl1;
            this.tv_Type.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1256, 763);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1226, 140);
            this.layoutControlGroup2.Text = "特殊日程编辑";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tv_Place;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(340, 38);
            this.layoutControlItem4.Text = "日程发生地";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tv_Type;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(340, 34);
            this.layoutControlItem1.Text = "日程类型";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateE_Start;
            this.layoutControlItem2.Location = new System.Drawing.Point(340, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(399, 34);
            this.layoutControlItem2.Text = "开始日期";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.colorEdit_Color;
            this.layoutControlItem6.Location = new System.Drawing.Point(739, 34);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(377, 38);
            this.layoutControlItem6.Text = "高亮颜色标记";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateE_End;
            this.layoutControlItem3.Location = new System.Drawing.Point(739, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(449, 34);
            this.layoutControlItem3.Text = "结束日期";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tv_Other;
            this.layoutControlItem5.Location = new System.Drawing.Point(340, 34);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(399, 38);
            this.layoutControlItem5.Text = "日程内容";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btn_Sure;
            this.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.layoutControlItem8.FillControlToClientArea = false;
            this.layoutControlItem8.Location = new System.Drawing.Point(1116, 34);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(72, 38);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(72, 38);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(72, 38);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            this.layoutControlItem8.TrimClientAreaToControl = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gridControl_specialDaily;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(1226, 593);
            this.layoutControlItem7.Text = "日程记录";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(108, 22);
            // 
            // UC_SpecialDailyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_SpecialDailyEdit";
            this.Size = new System.Drawing.Size(1256, 763);
            this.Load += new System.EventHandler(this.UC_SpecialDailyEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_specialDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_specialDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repo_HLE_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit_Color.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Other.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Place.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btn_Sure;
        private DevExpress.XtraGrid.GridControl gridControl_specialDaily;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_specialDaily;
        private DevExpress.XtraEditors.ColorEdit colorEdit_Color;
        private DevExpress.XtraEditors.TextEdit tv_Other;
        private DevExpress.XtraEditors.TextEdit tv_Place;
        private DevExpress.XtraEditors.DateEdit dateE_End;
        private DevExpress.XtraEditors.DateEdit dateE_Start;
        private DevExpress.XtraEditors.TextEdit tv_Type;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HLE_Delete;
    }
}
