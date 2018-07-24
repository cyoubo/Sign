using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Componet;
using Sign.Module_Sign.Model.Const;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Sign.Componet
{
    public class BudgetStatistician
    {
        public double SumEstimate { get; protected set; }
        public double FinishEstimate { get; protected set; }
        public double FinishAcutual { get; protected set; }

        public string toDisplayString()
        {
            return string.Format("总计预算 {0} 元 ，达成预算 {1} 元 ，实际支出 {2} 元", this.SumEstimate, FinishEstimate, this.FinishAcutual);
        }

        public BudgetStatistician Statistic(IDataBaseFactory factory)
        {
            string sql = string.Format("SELECT sum(TB_Budget.Estimate),sum(Actuality),sum((CASE WHEN Level = '{0}' THEN Actuality ELSE 0 END)) FROM TB_Budget",EnumBudgetState.Signed);
            using (var db = factory.OpenDefalutDataBase())
            {
               DataSet set = db.ExecuteSqlToDataSet(sql);
               SumEstimate = onConvertToDouble(set.Tables[0].Rows[0][0].ToString());
               FinishEstimate = onConvertToDouble(set.Tables[0].Rows[0][1].ToString());
               FinishAcutual = onConvertToDouble(set.Tables[0].Rows[0][2].ToString());
            }
            return this;
        }

        private double onConvertToDouble(string p)
        {
            if (string.IsNullOrEmpty(p))
                return 0;
            try
            {
                return double.Parse(p);
            }
            catch
            {
                return 0;
            }
        }
    }
}
