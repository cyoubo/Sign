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
using Sign.Module_Sign.View.Form;
using Sign.Module_Sign.Controller;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Sign.Module_Sign.Model;
using Sign.Module_System.Model;
using Sign.Module_Sign.Componet.Adapter;
using Sign.Module_Sign.Model.Const;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_ReadPlanEdit : DevExpress.XtraEditors.XtraUserControl, IInitialUI, IValidateInput2, ITabPageCloseCallBack
    {
        private TB_ReadPlanBuilder builder;
        private TB_ReadPlanAdapter adapter;
        private ReadPlanManageController controller;
        private GridControlHelper gridHelper;

        public UC_ReadPlanEdit()
        {
            InitializeComponent();
        }


        private void UC_ReadPlanEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            controller = new ReadPlanManageController();
            builder = new TB_ReadPlanBuilder();
            adapter = new TB_ReadPlanAdapter();
            gridHelper = new GridControlHelper(this.gridView_ReadPlan, this.gridControl_ReadPlan);
        }

        public void onInitialUI()
        {
            onLoadBookCatalog();

            if (adapter != null)
            {
                adapter.NotifyClearTable();
                adapter.NotifyDestoryTable();
            }

            adapter.Initial(controller.TravleAllEntities(), builder);
            adapter.NotifyfreshDataTable();
            gridHelper.GridControl.DataSource = adapter.ResultTable;

            gridHelper.setColunmsVisual(false, builder.ID,builder.Catalog);
            gridHelper.SetAllColumnEditable(false);
            gridHelper.setColunmsEdit(true,builder.Op_Delete, builder.Op_Edit,builder.Op_Giveup);
            gridHelper.SetCellResposity(builder.Op_Edit, Repo_HLE_Edit);
            gridHelper.SetCellResposity(builder.Op_Delete, Repo_HLE_Delete);
            gridHelper.SetCellResposity(builder.Op_Giveup, Repo_HLE_GiveupOrRestart);
            gridHelper.Group(builder.State);
            gridHelper.GridView.ExpandAllGroups();

            tv_Author.Text = "";
            tv_BookName.Text = "";
            dateE_Sign.DateTime = DateTime.Now.Date;

        }

        public void onExtractInputValue()
        {
            controller.Entry.Author= this.tv_Author.Text;
            controller.Entry.BookName = this.tv_BookName.Text;
            controller.Entry.Catalog = (this.cmb_Catalog.SelectedItem as TB_BookCatalog).ID;
            controller.Entry.CreateDate = controller.FormatDate(this.dateE_Sign.DateTime);
            controller.Entry.State = EnumBookPlanState.ToRead;
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(tv_BookName.Text, "书名");
            validator.NotNullFinishValidate(tv_Author.Text, "作者");
            validator.NotNullFinishValidate(cmb_Catalog.Text, "图书类别");
            return validator;
        }




        public void onLoadBookCatalog(string newCatalog = "")
        {
            cmb_Catalog.Properties.Items.Clear();
            foreach (TB_BookCatalog item in new ReadCatalogManageController().TravleAllEntities())
                cmb_Catalog.Properties.Items.Add(item);
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            Validator validator = onValidateInputValue();
            if (validator.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
                return;
            }

            if (controller.Entry == null)
            {
                controller.LoadEntry();
                onExtractInputValue();
                MessageBoxHelper.ShowCreateStateDialog(controller.InsertEntry());
            }
            else
            {
                onExtractInputValue();
                MessageBoxHelper.ShowUpdateStateDialog(controller.UpdateEntryByID());
            }

            controller.ReleaseEntry();
            onInitialUI();
            //同步更新阅读打卡界面，主要用于刷新书籍下拉菜单
            GParam.Create().Mediator.NotifyUpdateBookSign();
        }


        public void onPageClosed(object sender, EventArgs e)
        {
            GParam.Create().Mediator.RemoveActor(typeof(UC_ReadPlanEdit).Name);
        }


        private void Repo_HLE_Edit_Click(object sender, EventArgs e)
        {
            controller.CurrentID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            controller.LoadEntry();

            this.tv_Author.Text = controller.Entry.Author;
            this.tv_BookName.Text = controller.Entry.BookName;
            ControlAPI.SelectedComboxItemByText(this.cmb_Catalog, gridHelper.getFocuseRowCellValue_String(builder.CatalogName));
            this.dateE_Sign.DateTime = DateTime.Parse(controller.Entry.CreateDate);
        }

        private void Repo_HLE_Delete_Click(object sender, EventArgs e)
        {

            int currentID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            //判断当前课程是否有课程打卡记录
            if (new ReadSignManageController().IsExistReadSign(currentID))
            {
                MessageBoxHelper.ShowDialog("提示", "当前书籍已经有阅读记录，不能够删除");
            }
            else
            {
                if (controller.DeleteEntryByID<TB_BookReadPlanSet>(currentID))
                {
                    MessageBoxHelper.ShowDeleteStateDialog(true);
                    onInitialUI();
                    //同步更新阅读打卡界面，主要用于刷新书籍下拉菜单
                    GParam.Create().Mediator.NotifyUpdateBookSign();
                }
                else
                    MessageBoxHelper.ShowDeleteStateDialog(false);
            }
        }

        private void Repo_HLE_GiveupOrRestart_Click(object sender, EventArgs e)
        {
            string state = gridHelper.getFocuseRowCellValue_String(builder.State);
            controller.CurrentID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            controller.LoadEntry();
            if (controller.GiveUpOrRestart(state, DateTime.Now.Date))
            {
                onInitialUI();
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);
        }
    }
}
