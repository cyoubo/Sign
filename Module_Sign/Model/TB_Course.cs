using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Sign.Model
{

    [Table("[TB_Course]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_Course : EntityBase
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
        public String Name
        {
            get { return GetPropertyValue<String>("Name"); }
            set { SetPropertyValue("Name", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Description
        {
            get { return GetPropertyValue<String>("Description"); }
            set { SetPropertyValue("Description", value); }
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
        public Int64 SumFrequency
        {
            get { return GetPropertyValue<Int64>("SumFrequency"); }
            set { SetPropertyValue("SumFrequency", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String StarDate
        {
            get { return GetPropertyValue<String>("StarDate"); }
            set { SetPropertyValue("StarDate", value); }
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
        public String State
        {
            get { return GetPropertyValue<String>("State"); }
            set { SetPropertyValue("State", value); }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }

    [Table("[TB_Course]", DbType.Sqlite)]
    public class TB_CourseSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_Course]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_Course]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_Course]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase Name = new FieldBase(DbType.Sqlite, "[TB_Course]", FieldType.Common, "[Name]");
        public static readonly FieldBase Description = new FieldBase(DbType.Sqlite, "[TB_Course]", FieldType.Common, "[Description]");
        public static readonly FieldBase CatalogID = new FieldBase(DbType.Sqlite, "[TB_Course]", FieldType.Common, "[CatalogID]");
        public static readonly FieldBase SumFrequency = new FieldBase(DbType.Sqlite, "[TB_Course]", FieldType.Common, "[SumFrequency]");
        public static readonly FieldBase StarDate = new FieldBase(DbType.Sqlite, "[TB_Course]", FieldType.Common, "[StarDate]");
        public static readonly FieldBase EndDate = new FieldBase(DbType.Sqlite, "[TB_Course]", FieldType.Common, "[EndDate]");
        public static readonly FieldBase State = new FieldBase(DbType.Sqlite, "[TB_Course]", FieldType.Common, "[State]");
    }

}
