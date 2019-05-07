using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Moon.Orm;
using Sign.Module_System.Model;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using Sign.Module_Sign.View.UControl;
using Sign.Module_Sign.View.Form;
using Sign.Module_Sign.Model.Const;

namespace Sign.Module_System.View.Form
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm, IInitialUI
    {
        TabControlHelper tabHelper;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            tabHelper = new TabControlHelper(ContentTabs);
            tabHelper.RegistCloseEventListener();
        }

        public void onInitialUI()
        {
            tabHelper.ClearTabPage();
        }

        private void barbtn_BookManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_ReadPlanEdit content = new UC_ReadPlanEdit();
            tabHelper.AddorShowTabPage(barbtn_BookManage.Caption, content);

            GParam.Create().Mediator.AddActor(typeof(UC_ReadPlanEdit).Name, content);
        }

        private void barbtn_ReadRecord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBookCatalogEdit frm = new FrmBookCatalogEdit();
            frm.ShowDialog();
        }

        private void barBtn_ReadSign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_ReadSignScan content = new UC_ReadSignScan();
            tabHelper.AddorShowTabPage(barBtn_ReadSign.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_ReadSignScan).Name, content);
        }

        private void barbtn_SignReadBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_ReadSignEdit content = new UC_ReadSignEdit();
            tabHelper.AddorShowTabPage(barbtn_SignReadBook.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_ReadSignEdit).Name, content);
        }

        private void barBtn_GYMCatalog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGYMCatalogEdit frm = new FrmGYMCatalogEdit();
            frm.ShowDialog();
        }

        private void barBtn_GYMSign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_GYMSignEdit content = new UC_GYMSignEdit();
            tabHelper.AddorShowTabPage(barBtn_GYMSign.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_GYMSignEdit).Name, content);
           
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_GYMSignScan content = new UC_GYMSignScan();
            tabHelper.AddorShowTabPage(barButtonItem3.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_GYMSignScan).Name, content);
        }

        private void barBtn_DailyCatalog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDailyPlanCatalogEdit frm = new FrmDailyPlanCatalogEdit();
            frm.ShowDialog();
        }

        private void barBtn_DailyPlanSign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_DailyPlanSignEdit content = new UC_DailyPlanSignEdit();
            tabHelper.AddorShowTabPage(barBtn_DailyPlanSign.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_DailyPlanSignEdit).Name,content);
        }

        private void barBtn_DailyPlanSignScan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_DailyPlanSignScan content = new UC_DailyPlanSignScan();
            tabHelper.AddorShowTabPage(barBtn_DailyPlanSignScan.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_DailyPlanSignScan).Name, content);
        }

        private void BarBtn_DailyPlanUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_DailyPlanSignUpdate content = new UC_DailyPlanSignUpdate();
            tabHelper.AddorShowTabPage(BarBtn_DailyPlanUpdate.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_DailyPlanSignUpdate).Name, content);
        }

       

        

        private void BarBtn_BussinisTravel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_SpecialDailyEdit content = new UC_SpecialDailyEdit(EnumSpecialDailyType.BusinessTravel);
            tabHelper.AddorShowTabPage(BarBtn_BussinisTravel.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_SpecialDailyEdit).Name, content);
        }

        private void barBtn_Disease_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_SpecialDailyEdit content = new UC_SpecialDailyEdit(EnumSpecialDailyType.Disease);
            tabHelper.AddorShowTabPage(barBtn_Disease.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_SpecialDailyEdit).Name, content);
        }

        private void barBtn_VacationTravel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_SpecialDailyEdit content = new UC_SpecialDailyEdit(EnumSpecialDailyType.VacationTravel);
            tabHelper.AddorShowTabPage(barBtn_VacationTravel.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_SpecialDailyEdit).Name, content);
        }

        private void barBtn_BudgetCatalogEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBudgetCatalogEdit frm = new FrmBudgetCatalogEdit();
            frm.ShowDialog();
        }

        private void barBtn_BudgetSign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_BudgetSign content = new UC_BudgetSign();
            tabHelper.AddorShowTabPage(barBtn_BudgetSign.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_BudgetSign).Name, content);
        }

        private void batBtn_weed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_BudgetWeed content = new UC_BudgetWeed();
            tabHelper.AddorShowTabPage(batBtn_weed.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_BudgetWeed).Name, content);
        }

        private void barBtn_GYMCompare_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_GYMCompare content = new UC_GYMCompare();
            tabHelper.AddorShowTabPage(barBtn_GYMCompare.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_GYMCompare).Name, content);
        }

        private void barBtn_SpecialDailyScheduler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_SpecialDailyCalender content = new UC_SpecialDailyCalender();
            tabHelper.AddorShowTabPage(barBtn_SpecialDailyScheduler.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_SpecialDailyCalender).Name, content);
        }

        private void barBtn__ReadPlanCompare_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_ReadPlanCompare content = new UC_ReadPlanCompare();
            tabHelper.AddorShowTabPage(barBtn__ReadPlanCompare.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_ReadPlanCompare).Name, content);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_DailyPlanSignCompare content = new UC_DailyPlanSignCompare();
            tabHelper.AddorShowTabPage(this.barBtn_DailyPlanSignCompare.Caption, content);
            GParam.Create().Mediator.AddActor(typeof(UC_DailyPlanSignCompare).Name, content);
        }

        private void barBtn_DataBaseConnect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_DataBaseConnect frm = new Frm_DataBaseConnect();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void barBtn_DailyPlanStatistican_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_DailyPlanSignStatistician content = new UC_DailyPlanSignStatistician();
            tabHelper.AddorShowTabPage(barBtn_DailyPlanStatistican.Caption, content);
            GParam.Create().Mediator.AddActor(content.GetType().Name, content);
        }

        private void barBtn_SalaryPlan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_SalaryPlan content = new UC_SalaryPlan();
            tabHelper.AddorShowTabPage(barBtn_SalaryPlan.Caption, content);
            GParam.Create().Mediator.AddActor(content.GetType().Name, content);
        }

        private void barBtn_TechniqueCatalogEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barBtn_UC_ExportBusinesStripExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_ExportBusinesStripExcel content = new UC_ExportBusinesStripExcel();
            tabHelper.AddorShowTabPage(barBtn_UC_ExportBusinesStripExcel.Caption, content);
            GParam.Create().Mediator.AddActor(content.GetType().Name, content);
        }
    }
}