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
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_Common.Component.DataBaseConnect;
using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.ConstDef;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using Moon.Orm;

namespace Sign.Module_System.View.Form
{
    public partial class Frm_DataBaseConnect : DevExpress.XtraEditors.XtraForm,IInitialUI,IValidateInput2
    {
        private SQLiteConnectParam param;
        private ConnectStrInvoker Invoker;

        public Frm_DataBaseConnect()
        {
            InitializeComponent();
        }

        private void Frm_DataBaseConnect_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            param = new SQLiteConnectParam();
            Invoker = new ConnectStrInvoker();
        }

        public void onInitialUI()
        {
            Invoker.DeSerializationConnectStrFromAppConfig(param, DBConst.DBConfigName);
            tv_Datasource.Text = param.DataSource;
            tv_Version.Text = param.Version;
        }

        public void onExtractInputValue()
        {
            param.DataSource = tv_Datasource.Text;
            param.Version = tv_Version.Text;
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(tv_Datasource.Text, layoutControlItem1.Text);
            return validator;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Validator validator = onValidateInputValue();
            if (validator.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
                return;
            }

            onExtractInputValue();

            if (Invoker.SerializationConnectStrToAppConfig(param, DBConst.DBConfigName, DBConst.PrividerName))
                MessageBoxHelper.ShowUpdateStateDialog(true);
            else
                MessageBoxHelper.ShowErrorDialog(Invoker.ErrorMessage);
        }

        private void Btn_Test_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = Db.CreateDbByConfigName(DBConst.DBConfigName))
                {
                    string message = db != null ? "连接成功" : "连接失败";
                    SpaceItem.Text = message;
                }
            }
            catch (Exception ex)
            {
                SpaceItem.Text = ex.Message;
            }
        }
    }
}