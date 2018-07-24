using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Sign.Model
{

    [Table("[TB_CourseSign]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_CourseSign : EntityBase
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
        public Int64 CourseID
        {
            get { return GetPropertyValue<Int64>("CourseID"); }
            set { SetPropertyValue("CourseID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String SignDate
        {
            get { return GetPropertyValue<String>("SignDate"); }
            set { SetPropertyValue("SignDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 Frequency
        {
            get { return GetPropertyValue<Int64>("Frequency"); }
            set { SetPropertyValue("Frequency", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Context
        {
            get { return GetPropertyValue<String>("Context"); }
            set { SetPropertyValue("Context", value); }
        }
    }

    [Table("[TB_CourseSign]", DbType.Sqlite)]
    public class TB_CourseSignSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_CourseSign]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_CourseSign]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_CourseSign]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase CourseID = new FieldBase(DbType.Sqlite, "[TB_CourseSign]", FieldType.Common, "[CourseID]");
        public static readonly FieldBase SignDate = new FieldBase(DbType.Sqlite, "[TB_CourseSign]", FieldType.Common, "[SignDate]");
        public static readonly FieldBase Frequency = new FieldBase(DbType.Sqlite, "[TB_CourseSign]", FieldType.Common, "[Frequency]");
        public static readonly FieldBase Context = new FieldBase(DbType.Sqlite, "[TB_CourseSign]", FieldType.Common, "[Context]");
    }

}
