using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Sign.Model
{

    [Table("[TB_SpecialDaily]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_SpecialDaily : EntityBase
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
        public String Type
        {
            get { return GetPropertyValue<String>("Type"); }
            set { SetPropertyValue("Type", value); }
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
        public String Place
        {
            get { return GetPropertyValue<String>("Place"); }
            set { SetPropertyValue("Place", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Other
        {
            get { return GetPropertyValue<String>("Other"); }
            set { SetPropertyValue("Other", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Color
        {
            get { return GetPropertyValue<String>("Color"); }
            set { SetPropertyValue("Color", value); }
        }
    }

    [Table("[TB_SpecialDaily]", DbType.Sqlite)]
    public class TB_SpecialDailySet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_SpecialDaily]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_SpecialDaily]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_SpecialDaily]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase Type = new FieldBase(DbType.Sqlite, "[TB_SpecialDaily]", FieldType.Common, "[Type]");
        public static readonly FieldBase StartDate = new FieldBase(DbType.Sqlite, "[TB_SpecialDaily]", FieldType.Common, "[StartDate]");
        public static readonly FieldBase EndDate = new FieldBase(DbType.Sqlite, "[TB_SpecialDaily]", FieldType.Common, "[EndDate]");
        public static readonly FieldBase Place = new FieldBase(DbType.Sqlite, "[TB_SpecialDaily]", FieldType.Common, "[Place]");
        public static readonly FieldBase Other = new FieldBase(DbType.Sqlite, "[TB_SpecialDaily]", FieldType.Common, "[Other]");
        public static readonly FieldBase Color = new FieldBase(DbType.Sqlite, "[TB_SpecialDaily]", FieldType.Common, "[Color]");
    }

}
