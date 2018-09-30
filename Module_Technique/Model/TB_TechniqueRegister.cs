using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Technique.Model
{

    [Table("[TB_TechniqueRegister]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_TechniqueRegister : EntityBase
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
        public Int64 TechniqueID
        {
            get { return GetPropertyValue<Int64>("TechniqueID"); }
            set { SetPropertyValue("TechniqueID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 TechniqueStatue
        {
            get { return GetPropertyValue<Int64>("TechniqueStatue"); }
            set { SetPropertyValue("TechniqueStatue", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Reason
        {
            get { return GetPropertyValue<String>("Reason"); }
            set { SetPropertyValue("Reason", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Summary
        {
            get { return GetPropertyValue<String>("Summary"); }
            set { SetPropertyValue("Summary", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Introspection
        {
            get { return GetPropertyValue<String>("Introspection"); }
            set { SetPropertyValue("Introspection", value); }
        }
    }

    [Table("[TB_TechniqueRegister]", DbType.Sqlite)]
    public class TB_TechniqueRegisterSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_TechniqueRegister]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_TechniqueRegister]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_TechniqueRegister]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase TechniqueID = new FieldBase(DbType.Sqlite, "[TB_TechniqueRegister]", FieldType.Common, "[TechniqueID]");
        public static readonly FieldBase TechniqueStatue = new FieldBase(DbType.Sqlite, "[TB_TechniqueRegister]", FieldType.Common, "[TechniqueStatue]");
        public static readonly FieldBase Reason = new FieldBase(DbType.Sqlite, "[TB_TechniqueRegister]", FieldType.Common, "[Reason]");
        public static readonly FieldBase Summary = new FieldBase(DbType.Sqlite, "[TB_TechniqueRegister]", FieldType.Common, "[Summary]");
        public static readonly FieldBase Introspection = new FieldBase(DbType.Sqlite, "[TB_TechniqueRegister]", FieldType.Common, "[Introspection]");
    }

}
