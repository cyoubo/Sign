using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Sign.Model
{

    [Table("[TB_DailyPlanSign]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_DailyPlanSign : EntityBase
    {

        /// <summary>
        /// 
        /// </summary>
        public Int64 ID
        {
            get { return GetPropertyValue<Int64>("ID"); }
            set { SetPropertyValue("ID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Date
        {
            get { return GetPropertyValue<String>("Date"); }
            set { SetPropertyValue("Date", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 CatalogID
        {
            get { return GetPropertyValue<Int64>("CatalogID"); }
            set { SetPropertyValue("CatalogID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Completion
        {
            get { return GetPropertyValue<String>("Completion"); }
            set { SetPropertyValue("Completion", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Other
        {
            get { return GetPropertyValue<String>("Other"); }
            set { SetPropertyValue("Other", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String IsSign
        {
            get { return GetPropertyValue<String>("IsSign"); }
            set { SetPropertyValue("IsSign", value); }
        }
    }

    [Table("[TB_DailyPlanSign]", DbType.Sqlite)]
    public class TB_DailyPlanSignSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_DailyPlanSign]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_DailyPlanSign]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_DailyPlanSign]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase Date = new FieldBase(DbType.Sqlite, "[TB_DailyPlanSign]", FieldType.Common, "[Date]");
        public static readonly FieldBase CatalogID = new FieldBase(DbType.Sqlite, "[TB_DailyPlanSign]", FieldType.Common, "[CatalogID]");
        public static readonly FieldBase Completion = new FieldBase(DbType.Sqlite, "[TB_DailyPlanSign]", FieldType.Common, "[Completion]");
        public static readonly FieldBase Other = new FieldBase(DbType.Sqlite, "[TB_DailyPlanSign]", FieldType.Common, "[Other]");
        public static readonly FieldBase IsSign = new FieldBase(DbType.Sqlite, "[TB_DailyPlanSign]", FieldType.Common, "[IsSign]");
    }

}
