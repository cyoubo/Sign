using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_Common.Utils;
using PS.Plot.FrameBasic.Module_Common.Component;
using Sign.Module_Sign.Componet;

namespace Sign.Module_Sign.View.UControl
{
    public partial class UC_SalaryPlan : DevExpress.XtraEditors.XtraUserControl, IInitialUI, IValidateInput2
    {
        private SalaryPlanCalculator calculator;

        public UC_SalaryPlan()
        {
            InitializeComponent();
        }

        private void UC_SalaryPlan_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            calculator = new SalaryPlanCalculator();
        }

        public void onInitialUI()
        {
            DateUtils utils = new DateUtils();
            tv_daycount.Text = ""+(utils.MonthLastDay(DateTime.Now.Date).Subtract(utils.MonthLastDay(DateTime.Now.Date)).Days + 1);

            tv_Consume_Deposit.Text = ""+0;
            tv_Consume_JD.Text = "" + 0;
            tv_Consume_Budget.Text = "" + 0;
            tv_Consume_Redict.Text = "" + 0;
            tv_Consume_Special.Text = "" + 0;
        }

        public void onExtractInputValue()
        {
            calculator.Salary = onExtractDouble(tv_salary.Text);
            calculator.Consume_JD = onExtractDouble(tv_Consume_JD.Text);
            calculator.Consume_Budget = onExtractDouble(tv_Consume_Budget.Text);
            calculator.Consume_Deposit = onExtractDouble(tv_Consume_Deposit.Text);
            calculator.Consume_Special = onExtractDouble(tv_Consume_Special.Text);
            calculator.Consume_Redict = onExtractDouble(tv_Consume_Redict.Text);
            calculator.DayCount = onExtractDouble(tv_daycount.Text);
        }

        public PS.Plot.FrameBasic.Module_Common.Component.Validator onValidateInputValue()
        {
            return null;
        }

        private double onExtractDouble(string text)
        {
            return string.IsNullOrEmpty(text) ? 0 : double.Parse(text);
        }

        private string FormatDouble(double value)
        {
            return value.ToString("f2");
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            onExtractInputValue();

            calculator.Calculator();

            tv_Balance_CCB.Text = FormatDouble(calculator.Balance_CCB);
            tv_Balance_CMB.Text = FormatDouble(calculator.Balance_CMB);
            tv_Balance_WeBank.Text = FormatDouble(calculator.Balance_WeBank);
            tv_DayCustom.Text = FormatDouble(calculator.DayCustom);
            tv_DayCustomWithSpecial.Text = FormatDouble(calculator.DayCustomWithSpecial);
            tv_Rest.Text = FormatDouble(calculator.Rest);

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            onInitialUI();
        }
    }
}
