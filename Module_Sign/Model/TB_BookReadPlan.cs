using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Sign.Model
{

    [Table("[TB_BookReadPlan]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_BookReadPlan : EntityBase
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
        public String BookName
        {
            get { return GetPropertyValue<String>("BookName"); }
            set { SetPropertyValue("BookName", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Author
        {
            get { return GetPropertyValue<String>("Author"); }
            set { SetPropertyValue("Author", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String CreateDate
        {
            get { return GetPropertyValue<String>("CreateDate"); }
            set { SetPropertyValue("CreateDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String StartDate
        {
            get { return GetPropertyValue<String>("StartDate"); }
            set { SetPropertyValue("StartDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String EndDate
        {
            get { return GetPropertyValue<String>("EndDate"); }
            set { SetPropertyValue("EndDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 Catalog
        {
            get { return GetPropertyValue<Int64>("Catalog"); }
            set { SetPropertyValue("Catalog", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String State
        {
            get { return GetPropertyValue<String>("State"); }
            set { SetPropertyValue("State", value); }
        }

        public override string ToString()
        {
            return this.BookName;
        }
    }

    [Table("[TB_BookReadPlan]", DbType.Sqlite)]
    public class TB_BookReadPlanSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite, "[TB_BookReadPlan]", fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite, "[TB_BookReadPlan]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_BookReadPlan]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase BookName = new FieldBase(DbType.Sqlite, "[TB_BookReadPlan]", FieldType.Common, "[BookName]");
        public static readonly FieldBase Author = new FieldBase(DbType.Sqlite, "[TB_BookReadPlan]", FieldType.Common, "[Author]");
        public static readonly FieldBase CreateDate = new FieldBase(DbType.Sqlite, "[TB_BookReadPlan]", FieldType.Common, "[CreateDate]");
        public static readonly FieldBase StartDate = new FieldBase(DbType.Sqlite, "[TB_BookReadPlan]", FieldType.Common, "[StartDate]");
        public static readonly FieldBase EndDate = new FieldBase(DbType.Sqlite, "[TB_BookReadPlan]", FieldType.Common, "[EndDate]");
        public static readonly FieldBase Catalog = new FieldBase(DbType.Sqlite, "[TB_BookReadPlan]", FieldType.Common, "[Catalog]");
        public static readonly FieldBase State = new FieldBase(DbType.Sqlite, "[TB_BookReadPlan]", FieldType.Common, "[State]");
    }
}
