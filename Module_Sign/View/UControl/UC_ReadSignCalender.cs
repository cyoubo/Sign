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
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools.ChartHelper2;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_ReadSignCalender : DevExpress.XtraEditors.XtraUserControl,IInitialUI
    {
        private ChartControlHelper chartHelper;
        private SingleDataValueSeriesBuilder dataBuilder;

        public UC_ReadSignCalender()
        {
            InitializeComponent();
        }

        private void UC_ReadSignCalender_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            throw new NotImplementedException();
        }

        public void onInitialUI()
        {
            throw new NotImplementedException();
        }
    }
}
