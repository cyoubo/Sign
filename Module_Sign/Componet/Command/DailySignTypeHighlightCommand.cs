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
    public class DailySignTypeHighlightCommand : HighLightRowCommand
    {
        private TB_DailyPlanSignEditBuilder builder;
        
        public DailySignTypeHighlightCommand()
        {
            builder = new TB_DailyPlanSignEditBuilder();
        }

        public override void ExecuteHighLight(GridControlHelper gridControlHelper, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle != -1)
            {
                string typeStr = (gridControlHelper.GridControl.DataSource as DataTable).Rows[e.RowHandle][builder.Type].ToString();
                switch (typeStr.Trim())
                {
                    case "积极": e.Appearance.BackColor = Color.LightGreen; break;
                    case "消极": e.Appearance.BackColor = Color.LightPink; break;
                    case "中性": e.Appearance.BackColor = Color.LightBlue; break;
                }
            }
        }
    }
}
