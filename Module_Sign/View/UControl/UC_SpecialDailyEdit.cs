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
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Interface;
using Sign.Module_System.Model;
using Sign.Module_Sign.Componet.Adapter;
using Sign.Module_Sign.Controller;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Model;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_SpecialDailyEdit : DevExpress.XtraEditors.XtraUserControl, IInitialUI, IValidateInput2, ITabPageCloseCallBack
    {
        public string CurrentSpecialDailyType { get; set; }

        private TB_SpecialDailyBuilder builder;
        private TB_SpecialDailyAdapter adpater;
        private SpecialDailyManageController controller;
        private GridControlHelper gridHelper;

        public UC_SpecialDailyEdit(string DailyType)
        {
            InitializeComponent();
            CurrentSpecialDailyType = DailyType;
        }

        private void UC_SpecialDailyEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_SpecialDailyBuilder();
            adpater = new TB_SpecialDailyAdapter();
            controller = new SpecialDailyManageController();
            gridHelper = new GridControlHelper(this.gridView_specialDaily, this.gridControl_specialDaily);
        }

        public void onInitialUI()
        {
            tv_Type.Text = CurrentSpecialDailyType;
            dateE_Start.DateTime = DateTime.Now.Date;
            dateE_End.Text = "";
            tv_Other.Text = "";
            tv_Place.Text = "";

            if (adpater != null)
            {
                adpater.NotifyClearTable();
                adpater.NotifyDestoryTable();
            }

            adpater.Initial(controller.QueryEntriesByType(CurrentSpecialDailyType), builder);
            adpater.NotifyfreshDataTable();

            gridHelper.GridControl.DataSource = adpater.ResultTable;
            gridHelper.setColunmsVisual(false, builder.ID,builder.Type,builder.Color);
            gridHelper.SetAllColumnEditable(false);
            gridHelper.SetCellResposity(builder.Op_Delete, Repo_HLE_Delete);
            gridHelper.SetCellResposity(builder.Op_Edit, Repo_HLE_Edit);
            gridHelper.DisplayRowIndex();
            
        }

        public void onExtractInputValue()
        {
            controller.Entry.Type = tv_Type.Text;
            controller.Entry.StartDate = controller.FormatDate(dateE_Start.DateTime.Date);
            controller.Entry.EndDate = string.IsNullOrEmpty(dateE_End.Text) ? "" : controller.FormatDate(dateE_End.DateTime.Date);
            controller.Entry.Place = tv_Place.Text;
            controller.Entry.Other = tv_Other.Text;
            controller.Entry.Color = System.Drawing.ColorTranslator.ToHtml(colorEdit_Color.Color);
        }

        public Validator onValidateInputValue()
        {
            Validator validate = new Validator();
            validate.DateRangeValidate(this.dateE_Start.DateTime,this.dateE_End.DateTime);
            return validate;
        }

        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_SpecialDailyEdit).Name);
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            if (controller.Entry == null)
            {
                controller.LoadEntry();
                onExtractInputValue();
                if (controller.InsertEntry())
                {
                    onInitialUI();
                    GParam.Create().Mediator.NotifySpecialDailyCalender();
                }
                else
                    MessageBoxHelper.ShowCreateStateDialog(true);
            }
            else
            {
                onExtractInputValue();
                if (controller.UpdateEntryByID())
                {
                    onInitialUI();
                    GParam.Create().Mediator.NotifySpecialDailyCalender();
                }
                else
                    MessageBoxHelper.ShowUpdateStateDialog(false);
            }
        }

        private void Repo_HLE_Edit_Click(object sender, EventArgs e)
        {
            controller.CurrentID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            controller.LoadEntry(); 

            tv_Type.Text = controller.Entry.Type;
            dateE_Start.DateTime = DateTime.Parse(controller.Entry.StartDate);
            dateE_End.DateTime = string.IsNullOrEmpty(controller.Entry.EndDate) ? DateTime.Now.Date : DateTime.Parse(controller.Entry.EndDate);
            tv_Place.Text = controller.Entry.Place ;
            tv_Other.Text = controller.Entry.Other ;
            colorEdit_Color.Color = System.Drawing.ColorTranslator.FromHtml(controller.Entry.Color);

            controller.CurrentID = this.gridHelper.getFocuseRowCellValue_Int(builder.ID);
            controller.LoadEntry();
        }

        private void Repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            int currentID = this.gridHelper.getFocuseRowCellValue_Int(builder.ID);
            if (controller.DeleteEntryByID<TB_SpecialDailySet>(currentID))
            {
                onInitialUI();
                GParam.Create().Mediator.NotifySpecialDailyCalender();
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);
        }
    }
}
