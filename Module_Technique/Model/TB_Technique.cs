using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Technique.Model
{

    [Table("[TB_Technique]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_Technique : EntityBase
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
        public String Status
        {
            get { return GetPropertyValue<String>("Status"); }
            set { SetPropertyValue("Status", value); }
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
        public String PauseDate
        {
            get { return GetPropertyValue<String>("PauseDate"); }
            set { SetPropertyValue("PauseDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String FinishDate
        {
            get { return GetPropertyValue<String>("FinishDate"); }
            set { SetPropertyValue("FinishDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String AbandonDate
        {
            get { return GetPropertyValue<String>("AbandonDate"); }
            set { SetPropertyValue("AbandonDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 Interest
        {
            get { return GetPropertyValue<Int64>("Interest"); }
            set { SetPropertyValue("Interest", value); }
        }
    }

    [Table("[TB_Technique]", DbType.Sqlite)]
    public class TB_TechniqueSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_Technique]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_Technique]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_Technique]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase Name = new FieldBase(DbType.Sqlite, "[TB_Technique]", FieldType.Common, "[Name]");
        public static readonly FieldBase CatalogID = new FieldBase(DbType.Sqlite, "[TB_Technique]", FieldType.Common, "[CatalogID]");
        public static readonly FieldBase Description = new FieldBase(DbType.Sqlite, "[TB_Technique]", FieldType.Common, "[Description]");
        public static readonly FieldBase Status = new FieldBase(DbType.Sqlite, "[TB_Technique]", FieldType.Common, "[Status]");
        public static readonly FieldBase CreateDate = new FieldBase(DbType.Sqlite, "[TB_Technique]", FieldType.Common, "[CreateDate]");
        public static readonly FieldBase StartDate = new FieldBase(DbType.Sqlite, "[TB_Technique]", FieldType.Common, "[StartDate]");
        public static readonly FieldBase PauseDate = new FieldBase(DbType.Sqlite, "[TB_Technique]", FieldType.Common, "[PauseDate]");
        public static readonly FieldBase FinishDate = new FieldBase(DbType.Sqlite, "[TB_Technique]", FieldType.Common, "[FinishDate]");
        public static readonly FieldBase AbandonDate = new FieldBase(DbType.Sqlite, "[TB_Technique]", FieldType.Common, "[AbandonDate]");
        public static readonly FieldBase Interest = new FieldBase(DbType.Sqlite, "[TB_Technique]", FieldType.Common, "[Interest]");
    }

}
