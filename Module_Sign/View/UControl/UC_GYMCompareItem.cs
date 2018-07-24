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
using Sign.Module_Sign.Model;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools.ChartHelper2;
using Sign.Module_Sign.Controller;
using PS.Plot.FrameBasic.Module_Common.Interface;
using Sign.Module_Sign.Componet.Command;
using Sign.Module_System.Model;
using PS.Plot.FrameBasic.Module_Common.Utils;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_GYMCompareItem : DevExpress.XtraEditors.XtraUserControl, IGYMCompareItem
    {
        private ChartControlHelper chartHelper;
        private SingleDataValueSeriesBuilder dataBuilder;
        private GYMAPPARATUSStatistician statistician;

        private DateTime startDate, endDate;
        private TB_GYMCatalog currentCatalog;

        public UC_GYMCompareItem()
        {
            InitializeComponent();
        }

        private void UC_GYMCompareItem_Load(object sender, EventArgs e)
        {
            chartHelper = new ChartControlHelper(this.chartControl1);
            dataBuilder = new SingleDataValueSeriesBuilder();
            statistician = new GYMAPPARATUSStatistician(GParam.Create());

            startDate = DateTime.Now.Date;
            endDate = DateTime.Now.Date;

        }
        public void onInitialUI()
        {
            this.cmb_GymItem.Properties.Items.Clear();
            foreach (var item in new GYMCatalogManageController().TravleAllEntities())
                cmb_GymItem.Properties.Items.Add(item);
        }

        public void UpdateDateRange(DateTime startDate, DateTime endDate)
        {
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public void UpdateGYMCatalogItem(TB_GYMCatalog currentGymCatalog)
        {
            this.currentCatalog = currentGymCatalog;
        }

        public void UpdateChartGraphics()
        {
            if (currentCatalog != null)
            {
                if (dataBuilder != null)
                    dataBuilder.ClearDataSeries();
                dataBuilder.CreateSeries(currentCatalog.Name, DevExpress.XtraCharts.ViewType.Line);

                DataTable dt = statistician.StatisticDateRangeTypeTotal(currentCatalog.ID, startDate, endDate);
                foreach (DataRow row in dt.Rows)
                    dataBuilder.AddData(DateTime.Parse(row[0].ToString()), double.Parse(row[1].ToString()));

                chartHelper.ReplaceSeries(dataBuilder.DataSeries);
            }
        }

        private void cmb_GymItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGYMCatalogItem(this.cmb_GymItem.SelectedItem as TB_GYMCatalog);
            UpdateChartGraphics();
        }
    }

    public interface IGYMCompareItem
    {
        void UpdateDateRange(DateTime startDate, DateTime endDate);

        void UpdateGYMCatalogItem(TB_GYMCatalog currentGymCatalog);

        void UpdateChartGraphics();

        void onInitialUI();
    }
}
