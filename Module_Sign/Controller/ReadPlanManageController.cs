using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Controller;
using Sign.Module_Sign.Model;
using Sign.Module_Sign.Model.Const;
using Sign.Module_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign.Module_Sign.Controller
{
    public class ReadPlanManageController : ManageBaseController<TB_BookReadPlan>
    {
        public ReadPlanManageController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_BookReadPlanSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_BookReadPlan entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_BookReadPlan entry)
        {
            return TB_BookReadPlanSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_BookReadPlanSet.ID.Equal(entry);
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryEntryByID(int CurrentID)
        {
            return TB_BookReadPlanSet.SelectAll().Where(onBlindIDWhere(CurrentID));
        }

        //internal DateTime ConvertToDate(string p)
        //{
        //    DateTime result = new DateTime();
        //    try
        //    {
        //        result = DateTime.Parse(p);
        //    }
        //    catch (Exception ex)
        //    {
        //        GParam.Create().SystemLogger.Debug("ConvertToDate", ex);
        //    }
        //    return result;
        //}


        //public bool FinishReadPlan(long currentID)
        //{
        //    bool result = true;
        //    try
        //    {
        //        using (var db = this.dbFactory.OpenDefalutDataBase())
        //        {
        //            TB_BookReadPlan temp = db.GetEntity<TB_BookReadPlan>(onCreateMQL_QueryEntryByID((int)currentID));
        //            temp.State = (long)EnumBookPlanState.Read;
        //            db.Update(temp);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result = false;
        //        GParam.Create().SystemLogger.Debug("FinishReadPlan", ex);
        //    }
        //    return result;
        //}

        public bool UpdatePlanState(long planID, string state, DateTime dateTime)
        {
            bool result = true;
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                try
                {
                    TB_BookReadPlan tempPlan = db.GetEntity<TB_BookReadPlan>(TB_BookReadPlanSet.SelectAll().Where(TB_BookReadPlanSet.ID.Equal(planID)));
                    if (tempPlan.State.Equals(EnumBookPlanState.ToRead))
                    {
                        tempPlan.StartDate = FormatDate(dateTime);
                        if (state.Equals(EnumBookPlanState.Read))
                            tempPlan.EndDate = FormatDate(dateTime);
                        tempPlan.State = state;
                        tempPlan.WhereExpression = onBlindIDWhere(tempPlan);
                        db.Update(tempPlan);
                    }
                    else if (tempPlan.State.Equals(EnumBookPlanState.Reading))
                    {
                        if (state.Equals(EnumBookPlanState.Read))
                        {
                            tempPlan.EndDate = FormatDate(dateTime);
                            tempPlan.State = state;
                            tempPlan.WhereExpression = onBlindIDWhere(tempPlan);
                            db.Update(tempPlan);
                        }
                    }
                }
                catch (Exception ex)
                {
                    result = false;
                    GParam.Create().SystemLogger.Error("UpdatePlanState", ex);
                }
            }
            return result;
        }

        public List<TB_BookReadPlan> QueryUnFinishReadPlan()
        {
            List<TB_BookReadPlan> result = new List<TB_BookReadPlan>();
            using (var db = this.dbFactory.OpenDefalutDataBase())
            { 
                string[] temp = new string[]{EnumBookPlanState.ToRead,EnumBookPlanState.Reading};
                result.AddRange(db.GetEntities<TB_BookReadPlan>(TB_BookReadPlanSet.SelectAll().Where(TB_BookReadPlanSet.State.In(temp))));
            }
            return result;
        }

        public bool GiveUpOrRestart(string state, DateTime dateTime)
        {
            if (Entry.State.Equals(EnumBookPlanState.Giveup))
            {
                Entry.State = EnumBookPlanState.Reading;
                Entry.EndDate = "";
                return UpdateEntryByID();
            }
            else if (Entry.State.Equals(EnumBookPlanState.ToRead)||Entry.State.Equals(EnumBookPlanState.Reading))
            {
                Entry.State = EnumBookPlanState.Giveup;
                Entry.EndDate = FormatDate(dateTime);
                return UpdateEntryByID();
            }
            return true;
        }

        public bool RevokeReadState(int planID)
        {
            bool result = true;
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                try
                {
                    TB_BookReadPlan tempPlan = db.GetEntity<TB_BookReadPlan>(TB_BookReadPlanSet.SelectAll().Where(TB_BookReadPlanSet.ID.Equal(planID)));
                    if (tempPlan.State.Equals(EnumBookPlanState.Read))
                    {
                        tempPlan.State = EnumBookPlanState.Reading;
                        tempPlan.EndDate = "";
                        tempPlan.WhereExpression = onBlindIDWhere(tempPlan);
                        db.Update(tempPlan);
                    }
                }
                catch (Exception ex)
                {
                    result = false;
                    GParam.Create().SystemLogger.Error("RevokeReadState", ex);
                }
            }
            return result;
        }

        public bool RevokeReadingState(int planID)
        {
            bool result = true;
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                try
                {
                    TB_BookReadPlan tempPlan = db.GetEntity<TB_BookReadPlan>(TB_BookReadPlanSet.SelectAll().Where(TB_BookReadPlanSet.ID.Equal(planID)));
                    if (tempPlan.State.Equals(EnumBookPlanState.Reading))
                    {
                        tempPlan.State = EnumBookPlanState.ToRead;
                        tempPlan.EndDate = "";
                        tempPlan.WhereExpression = onBlindIDWhere(tempPlan);
                        db.Update(tempPlan);
                    }
                }
                catch (Exception ex)
                {
                    result = false;
                    GParam.Create().SystemLogger.Error("RevokeReadState", ex);
                }
            }
            return result;
        }

        public IDictionary<long, string> CreateCatalogNameMap()
        {
            Dictionary<long, string> result = new Dictionary<long, string>();
            foreach (var item in TravleAllEntities())
                result.Add(item.ID, item.BookName);
            return result;
        }
    }
}
