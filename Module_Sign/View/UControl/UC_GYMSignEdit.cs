using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using Sign.Module_Sign.Controller;
using Sign.Module_System.Model;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Component;
using Sign.Module_Sign.Componet.Adapter;
using Sign.Module_Sign.Model;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_GYMSignEdit : DevExpress.XtraEditors.XtraUserControl, IInitialUI, IValidateInput2, ITabPageCloseCallBack
    {
        private GYMBaseManageController gymbaseController;
        private GYMCatalogManageController gymCatalogController;
        private GYMAPPARATUSManageController gymAppController;

        private TB_GYMAPPARATUSAdapter appAdaptor;
        private TB_GYMAPPARATUSBuilder appBuilder;
        private GridControlHelper gridHelper;
        

        public UC_GYMSignEdit()
        {
            InitializeComponent();
        }

        private void UC_GYMSignEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            gymbaseController = new GYMBaseManageController();
            gymCatalogController = new GYMCatalogManageController();
            gymAppController = new GYMAPPARATUSManageController();
            appAdaptor = new TB_GYMAPPARATUSAdapter();
            appBuilder = new TB_GYMAPPARATUSBuilder();
            appAdaptor.Initial(appBuilder);
            
            gridHelper = new GridControlHelper(this.gridView_app, this.gridControl_app);
        }

        public void onInitialUI()
        {
            this.dateE_today.DateTime = DateTime.Now.Date;
            this.cmb_Catalog.Properties.Items.Clear();
            foreach (var item in gymCatalogController.TravleAllEntities())
                this.cmb_Catalog.Properties.Items.Add(item);

            appAdaptor.NotifyfreshDataTable();
            this.gridControl_app.DataSource = appAdaptor.ResultTable;
            gridHelper.SetColunmOption(appBuilder.BaseID, false, false);
            gridHelper.SetColunmOption(appBuilder.ID, false, false);
            gridHelper.SetCellResposity(appBuilder.Op_Delete, this.Repo_HLE_Delete);
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(this.tv_Calorie.Text, layoutControlItem2.Text);
            return validator;
        }

        public void onExtractInputValue()
        {
            gymbaseController.Entry.Calorie = int.Parse(this.tv_Calorie.Text);
            gymbaseController.Entry.Date = gymbaseController.FormatDate(this.dateE_today.DateTime.Date);
            gymbaseController.Entry.Other = this.tv_Other.Text;
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_GYMSignEdit).Name);
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            Validator valitor = onValidateInputValue();
            if (valitor.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(valitor.ErrorMessage);
                return;
            }

            gymbaseController.LoadEntry();

            onExtractInputValue();

            object baseEntryPK = null;
            if (gymbaseController.InsertEntry(out baseEntryPK))
            {
                bool result = gymAppController.InsertWithDeleteOldRecord(baseEntryPK, appAdaptor.DataList);
                if (result)
                    GParam.Create().Mediator.NotifyUpdateGYMSign();
                MessageBoxHelper.ShowCreateStateDialog(result);
            }
            else
                MessageBoxHelper.ShowCreateStateDialog(false);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(this.cmb_Catalog.Text, layoutControlItem3.Text);
            validator.NotNullFinishValidate(this.tv_Weight.Text, layoutControlItem4.Text);
            validator.NotNullFinishValidate(this.tv_GroupCount.Text, layoutControlItem5.Text);
            validator.NotNullFinishValidate(this.tv_Frenqucy.Text, layoutControlItem11.Text);
            if (validator.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
                return;
            }

            TB_GYMAPPARATUS appModel = new TB_GYMAPPARATUS();
            appModel.GroupCount = long.Parse(this.tv_GroupCount.Text);
            appModel.Weight = long.Parse(this.tv_Weight.Text);
            appModel.Frequency = long.Parse(this.tv_Frenqucy.Text);
            appModel.CatalogID = (this.cmb_Catalog.SelectedItem as TB_GYMCatalog).ID;
            appAdaptor.AddItem(appModel);
            gridHelper.GridControl.DataSource = appAdaptor.ResultTable;
        }

        private void Repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            appAdaptor.RemoveItem(gridView_app.FocusedRowHandle);
            appAdaptor.NotifyfreshDataTable();
            gridView_app.GridControl.DataSource = appAdaptor.ResultTable;
        }
    }
}
