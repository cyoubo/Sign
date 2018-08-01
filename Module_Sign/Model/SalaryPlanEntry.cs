using PS.Plot.FrameBasic.Module_Common.Component.FileOperator;
using PS.Plot.FrameBasic.Module_Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Sign.Model
{
    public class SalaryPlanEntry : IFileWriteCommand, IFileReadCommand
    {
        public double Salary { get; set; }
        public double Consume_JD { get; set; }
        public double Consume_Redict { get; set; }
        public double Consume_Budget { get; set; }
        public double Consume_Special { get; set; }
        public double Consume_Deposit { get; set; }
        public double DayCount { get; set; }

        public void WriteToFile(FileIOInvoker invoker)
        {
            string result = XmlUtils.Serializer(this.GetType(), this);
            invoker.Writer.WriteLine(result);
        }

        public void ReadFromFile(FileIOInvoker invoker)
        {
            SalaryPlanEntry temp = XmlUtils.Deserialize(this.GetType(), invoker.Readar.ReadToEnd()) as SalaryPlanEntry;
            this.Salary = temp.Salary;
            this.Consume_JD = temp.Consume_JD;
            this.Consume_Redict = temp.Consume_Redict;
            this.Consume_Budget = temp.Consume_Budget;
            this.Consume_Special = temp.Consume_Special;
            this.Consume_Deposit = temp.Consume_Deposit;
            this.DayCount = temp.DayCount;
        }
    }
}
