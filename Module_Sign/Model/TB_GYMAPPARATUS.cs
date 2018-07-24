using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Sign.Model
{

    [Table("[TB_GYMAPPARATUS]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_GYMAPPARATUS : EntityBase
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
        public Int64 BaseID
        {
            get { return GetPropertyValue<Int64>("BaseID"); }
            set { SetPropertyValue("BaseID", value); }
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
        public Int64 Weight
        {
            get { return GetPropertyValue<Int64>("Weight"); }
            set { SetPropertyValue("Weight", value); }
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
        public Int64 GroupCount
        {
            get { return GetPropertyValue<Int64>("GroupCount"); }
            set { SetPropertyValue("GroupCount", value); }
        }
    }

    [Table("[TB_GYMAPPARATUS]", DbType.Sqlite)]
    public class TB_GYMAPPARATUSSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_GYMAPPARATUS]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_GYMAPPARATUS]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_GYMAPPARATUS]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase BaseID = new FieldBase(DbType.Sqlite, "[TB_GYMAPPARATUS]", FieldType.Common, "[BaseID]");
        public static readonly FieldBase CatalogID = new FieldBase(DbType.Sqlite, "[TB_GYMAPPARATUS]", FieldType.Common, "[CatalogID]");
        public static readonly FieldBase Weight = new FieldBase(DbType.Sqlite, "[TB_GYMAPPARATUS]", FieldType.Common, "[Weight]");
        public static readonly FieldBase Frequency = new FieldBase(DbType.Sqlite, "[TB_GYMAPPARATUS]", FieldType.Common, "[Frequency]");
        public static readonly FieldBase GroupCount = new FieldBase(DbType.Sqlite, "[TB_GYMAPPARATUS]", FieldType.Common, "[GroupCount]");
    }

}
