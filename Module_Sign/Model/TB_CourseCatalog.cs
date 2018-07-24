using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Sign.Model
{

    [Table("[TB_CourseCatalog]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_CourseCatalog : EntityBase
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
        public String Other
        {
            get { return GetPropertyValue<String>("Other"); }
            set { SetPropertyValue("Other", value); }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }

    [Table("[TB_CourseCatalog]", DbType.Sqlite)]
    public class TB_CourseCatalogSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_CourseCatalog]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_CourseCatalog]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_CourseCatalog]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase Name = new FieldBase(DbType.Sqlite, "[TB_CourseCatalog]", FieldType.Common, "[Name]");
        public static readonly FieldBase Other = new FieldBase(DbType.Sqlite, "[TB_CourseCatalog]", FieldType.Common, "[Other]");
    }

}
