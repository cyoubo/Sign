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
using Sign.Module_Sign.Componet.Adapter;
using Sign.Module_Sign.Model;
using Sign.Module_System.Model;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Componet.Command;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_DailyPlanSignEdit : DevExpress.XtraEditors.XtraUserControl, IInitialUI, IValidateInput2, ITabPageCloseCallBack
    {
        private DailyPlanSignManageController Controller;
        private TB_DailyPlanSignEditBuilder builder;
        private GridControlHelper gridHelper;


        public UC_DailyPlanSignEdit()
        {
            InitializeComponent();
        }

        private void UC_DailyPlanSign_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            Controller = new DailyPlanSignManageController();
            builder = new TB_DailyPlanSignEditBuilder();
            gridHelper = new GridControlHelper(this.gridView_Sign, this.gridControl_Sign);
        }

        public void onInitialUI()
        {
            this.dateEdit1.DateTime = DateTime.Now.Date;
            this.repo_Combox_Completion.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            this.gridHelper.DestoryDataSource();

            this.gridControl_Sign.DataSource = builder.CreateDefalutCatalogItemTable();
            this.gridHelper.SetCellResposity(builder.IsSign, this.repo_CKE_IsSign);
            this.gridHelper.SetCellResposity(builder.Completion, this.repo_Combox_Completion);
            this.gridHelper.SetColunmOption(builder.CatalogID, false, false);
            this.gridHelper.SetColunmOption(builder.CatalogName, false, true);
            this.gridHelper.Group(builder.Type);
            this.gridView_Sign.ExpandAllGroups();

            this.gridHelper.SetColMaxWidth(builder.IsSign, 120);
        }

        public void onExtractInputValue()
        {
            throw new NotImplementedException();
        }

        public PS.Plot.FrameBasic.Module_Common.Component.Validator onValidateInputValue()
        {
            throw new NotImplementedException();
        }

        private void gridView_Sign_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
           
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_DailyPlanSignEdit).Name);
        }

        private void Btn_Sure_Click(object sender, EventArgs e)
        {
            if (Controller.InsertEntriesWithDateDelete(builder.ExtractEntries(this.gridControl_Sign.DataSource as DataTable), this.dateEdit1.DateTime.Date))
            {
                onInitialUI();
                GParam.Create().Mediator.NotifyDailyPlanSignScan();
            }
            else
                MessageBoxHelper.ShowCreateStateDialog(false);
        }
    }
}
