using PS.Plot.FrameBasic.Module_Common.Component.FileOperator;
using PS.Plot.FrameBasic.Module_Common.Utils;
using Sign.Module_Sign.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Sign.Componet
{
    public class SalaryPlanCalculator
    {
        public SalaryPlanEntry Entry { get; set; }

        public double Rest { get; protected set; }
        public double DayCustom { get; protected set; }
        public double DayCustomWithSpecial { get; protected set; }
        public double Balance_CCB { get; protected set; }
        public double Balance_CMB { get; protected set; }
        public double Balance_WeBank { get; protected set; }

        public SalaryPlanCalculator()
        {
            Entry = new SalaryPlanEntry();
        }

        public void Calculator()
        {
            Rest = Entry.Salary - Entry.Consume_JD - Entry.Consume_Redict - Entry.Consume_Budget - Entry.Consume_Deposit - Entry.Consume_Special;
            DayCustom = (Rest + Entry.Consume_Special) / Entry.DayCount;
            DayCustomWithSpecial = Rest / Entry.DayCount;

            Balance_WeBank = Entry.Consume_Deposit + Entry.Consume_Budget;
            Balance_CMB = Entry.Consume_Redict;
            Balance_CCB = Entry.Salary - Balance_CMB - Balance_WeBank;
        }

        public void SaveToXML()
        {
            FileIOInvoker invoker = FileIOInvoker.CreateFromRelativeFullPath(".\\config\\SalarPlan.xml");
            invoker.ExecuteWriteCommand(Entry);
        }

        public bool ReadFromXML()
        {
            FileIOInvoker invoker = FileIOInvoker.CreateFromRelativeFullPath(".\\config\\SalarPlan.xml");
            return invoker.ExecuteReadCommand(Entry);
        }
    }


}
