using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Sign.Model
{

    [Table("[TB_BookReadSign]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_BookReadSign : EntityBase
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
        public Int64 ReadPlanID
        {
            get { return GetPropertyValue<Int64>("ReadPlanID"); }
            set { SetPropertyValue("ReadPlanID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Other
        {
            get { return GetPropertyValue<String>("Other"); }
            set { SetPropertyValue("Other", value); }
        }
    }

    [Table("[TB_BookReadSign]", DbType.Sqlite)]
    public class TB_BookReadSignSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_BookReadSign]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_BookReadSign]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_BookReadSign]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase Date = new FieldBase(DbType.Sqlite, "[TB_BookReadSign]", FieldType.Common, "[Date]");
        public static readonly FieldBase ReadPlanID = new FieldBase(DbType.Sqlite, "[TB_BookReadSign]", FieldType.Common, "[ReadPlanID]");
        public static readonly FieldBase Other = new FieldBase(DbType.Sqlite, "[TB_BookReadSign]", FieldType.Common, "[Other]");
    }

}
