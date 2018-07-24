using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Sign.Model
{

    [Table("[TB_DailyPlanCatalog]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_DailyPlanCatalog : EntityBase
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
        public String Type
        {
            get { return GetPropertyValue<String>("Type"); }
            set { SetPropertyValue("Type", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Description
        {
            get { return GetPropertyValue<String>("Description"); }
            set { SetPropertyValue("Description", value); }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }

    [Table("[TB_DailyPlanCatalog]", DbType.Sqlite)]
    public class TB_DailyPlanCatalogSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_DailyPlanCatalog]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_DailyPlanCatalog]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_DailyPlanCatalog]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase Name = new FieldBase(DbType.Sqlite, "[TB_DailyPlanCatalog]", FieldType.Common, "[Name]");
        public static readonly FieldBase Type = new FieldBase(DbType.Sqlite, "[TB_DailyPlanCatalog]", FieldType.Common, "[Type]");
        public static readonly FieldBase Description = new FieldBase(DbType.Sqlite, "[TB_DailyPlanCatalog]", FieldType.Common, "[Description]");
    }

}
