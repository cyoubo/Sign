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
using Sign.Module_Sign.Componet;
using Sign.Module_Sign.Controller;
using PS.Plot.FrameBasic.Module_Common.Utils;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Model;
using DevExpress.XtraEditors.Controls;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_ExportBusinesStripExcel : DevExpress.XtraEditors.XtraUserControl,IInitialUI,IValidateInput2
    {
        private BusinesStripExcelInvoker invoker;
        private DailyPlanCatalogManageController controller;

        public UC_ExportBusinesStripExcel()
        {
            InitializeComponent();
        }

        private void UC_ExportBusinesStripExcel_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            invoker = new BusinesStripExcelInvoker();
            controller = new DailyPlanCatalogManageController();
        }

        public void onInitialUI()
        {
            this.checkList_Catalog.Items.Clear();
            foreach (var item in controller.TravleAllEntities())
                this.checkList_Catalog.Items.Add(item);

            DateUtils utils = new DateUtils();
            dateE_Start.DateTime = utils.GetWeekFirstDayMon(DateTime.Now).Date;
            dateE_End.DateTime = utils.GetWeekLastDaySun(DateTime.Now).Date;
        }

        public void onExtractInputValue()
        {
            invoker.StartDate = dateE_Start.DateTime.Date;
            invoker.EndDate = dateE_End.DateTime.Date;
            invoker.FilePath = btnE_Export.Text;
            foreach (CheckedListBoxItem item in this.checkList_Catalog.CheckedItems)
            {
                invoker.AppendDailyCatalog(item.Value as TB_DailyPlanCatalog);
            }
            
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(btnE_Export.Text, "输出路径");
            return validator;
        }

        private void btn_pickAll_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < this.checkList_Catalog.ItemCount; index++)
                this.checkList_Catalog.SetItemChecked(index, true);
            
        }

        private void btn_pickNo_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < this.checkList_Catalog.ItemCount; index++)
                this.checkList_Catalog.SetItemChecked(index, true);
        }

        private void btn_pickRevser_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < this.checkList_Catalog.ItemCount; index++)
                this.checkList_Catalog.SetItemChecked(index, !this.checkList_Catalog.GetItemChecked(index));
        }

        private void btnE_Export_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "*.xls|*.xls";
            dialog.FileName = string.Format("出差登记{0}-{1}", controller.FormatDate(dateE_Start.DateTime), controller.FormatDate(dateE_End.DateTime));
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                btnE_Export.Text = dialog.FileName;
            }
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            Validator validator = onValidateInputValue();
            if (validator.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
                return;
            }

            onExtractInputValue();
            
            MessageBoxHelper.ShowCreateStateDialog(invoker.Export());
        }
    }
}
