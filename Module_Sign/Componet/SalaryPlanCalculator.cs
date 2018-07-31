using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Sign.Componet
{
    public class SalaryPlanCalculator
    {
        public double Salary { get; set; }
        public double Consume_JD { get; set; }
        public double Consume_Redict { get; set; }
        public double Consume_Budget { get; set; }
        public double Consume_Special { get; set; }
        public double Consume_Deposit { get; set; }
        public double DayCount { get; set; }

        public double Rest { get; protected set; }

        public double DayCustom { get; protected set; }

        public double DayCustomWithSpecial { get; protected set; }

        public double Balance_CCB { get; protected set; }

        public double Balance_CMB { get; protected set; }

        public double Balance_WeBank { get; protected set; }


        public void Calculator()
        {
            Rest = Salary - Consume_JD - Consume_Redict - Consume_Budget - Consume_Deposit - Consume_Special;
            DayCustom = (Rest + Consume_Special) / DayCount;
            DayCustomWithSpecial = Rest / DayCount;

            Balance_WeBank = Consume_Deposit + Consume_Budget;
            Balance_CMB = Consume_Redict;
            Balance_CCB = Salary - Balance_CMB - Balance_WeBank;
        }
    }
}
