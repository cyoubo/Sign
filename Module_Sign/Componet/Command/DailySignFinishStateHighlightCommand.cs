using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using Sign.Module_Sign.Componet.Adapter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Sign.Componet.Command
{
    public class DailySignFinishStateHighlightCommand : HighLightRowCommand
    {
        private TB_DailyPlanSignBuilder builder;

        public DailySignFinishStateHighlightCommand()
        {
            this.builder = new TB_DailyPlanSignBuilder();
        }

        public override void ExecuteHighLight(GridControlHelper gridControlHelper, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle != -1)
            {
                if (Boolean.Parse((gridControlHelper.GridControl.DataSource as DataTable).Rows[e.RowHandle][builder.IsSign].ToString()))
                {
                    e.Appearance.BackColor = Color.LightGreen;
                }
            }
        }
    }
}
