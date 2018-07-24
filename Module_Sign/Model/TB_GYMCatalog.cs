using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Sign.Model
{

    [Table("[TB_GYMCatalog]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_GYMCatalog : EntityBase
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

        public override string ToString()
        {
            return this.Name;
        }
    }

    [Table("[TB_GYMCatalog]", DbType.Sqlite)]
    public class TB_GYMCatalogSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_GYMCatalog]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_GYMCatalog]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_GYMCatalog]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase Name = new FieldBase(DbType.Sqlite, "[TB_GYMCatalog]", FieldType.Common, "[Name]");
        public static readonly FieldBase Description = new FieldBase(DbType.Sqlite, "[TB_GYMCatalog]", FieldType.Common, "[Description]");
    }

}
