using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Sign.Model
{

    [Table("[TB_Budget]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_Budget : EntityBase
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
        public Int64 CatalogID
        {
            get { return GetPropertyValue<Int64>("CatalogID"); }
            set { SetPropertyValue("CatalogID", value); }
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
        public String SignDate
        {
            get { return GetPropertyValue<String>("SignDate"); }
            set { SetPropertyValue("SignDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Double Estimate
        {
            get { return GetPropertyValue<Double>("Estimate"); }
            set { SetPropertyValue("Estimate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String WeedDate
        {
            get { return GetPropertyValue<String>("WeedDate"); }
            set { SetPropertyValue("WeedDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Double Actuality
        {
            get { return GetPropertyValue<Double>("Actuality"); }
            set { SetPropertyValue("Actuality", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String DifferentReason
        {
            get { return GetPropertyValue<String>("DifferentReason"); }
            set { SetPropertyValue("DifferentReason", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 Level
        {
            get { return GetPropertyValue<Int64>("Level"); }
            set { SetPropertyValue("Level", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String State
        {
            get { return GetPropertyValue<String>("State"); }
            set { SetPropertyValue("State", value); }
        }
    }

    [Table("[TB_Budget]", DbType.Sqlite)]
    public class TB_BudgetSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_Budget]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_Budget]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_Budget]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase Name = new FieldBase(DbType.Sqlite, "[TB_Budget]", FieldType.Common, "[Name]");
        public static readonly FieldBase CatalogID = new FieldBase(DbType.Sqlite, "[TB_Budget]", FieldType.Common, "[CatalogID]");
        public static readonly FieldBase Description = new FieldBase(DbType.Sqlite, "[TB_Budget]", FieldType.Common, "[Description]");
        public static readonly FieldBase SignDate = new FieldBase(DbType.Sqlite, "[TB_Budget]", FieldType.Common, "[SignDate]");
        public static readonly FieldBase Estimate = new FieldBase(DbType.Sqlite, "[TB_Budget]", FieldType.Common, "[Estimate]");
        public static readonly FieldBase WeedDate = new FieldBase(DbType.Sqlite, "[TB_Budget]", FieldType.Common, "[WeedDate]");
        public static readonly FieldBase Actuality = new FieldBase(DbType.Sqlite, "[TB_Budget]", FieldType.Common, "[Actuality]");
        public static readonly FieldBase DifferentReason = new FieldBase(DbType.Sqlite, "[TB_Budget]", FieldType.Common, "[DifferentReason]");
        public static readonly FieldBase Level = new FieldBase(DbType.Sqlite, "[TB_Budget]", FieldType.Common, "[Level]");
        public static readonly FieldBase State = new FieldBase(DbType.Sqlite, "[TB_Budget]", FieldType.Common, "[State]");
    }

}
