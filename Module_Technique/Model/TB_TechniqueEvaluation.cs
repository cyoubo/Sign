using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace Sign.Module_Technique.Model
{

    [Table("[TB_TechniqueEvaluation]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_TechniqueEvaluation : EntityBase
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
        public Int64 JobRelation
        {
            get { return GetPropertyValue<Int64>("JobRelation"); }
            set { SetPropertyValue("JobRelation", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 IndustryRelation
        {
            get { return GetPropertyValue<Int64>("IndustryRelation"); }
            set { SetPropertyValue("IndustryRelation", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 TargetDefinition
        {
            get { return GetPropertyValue<Int64>("TargetDefinition"); }
            set { SetPropertyValue("TargetDefinition", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 Technique
        {
            get { return GetPropertyValue<Int64>("Technique"); }
            set { SetPropertyValue("Technique", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 SystemSize
        {
            get { return GetPropertyValue<Int64>("SystemSize"); }
            set { SetPropertyValue("SystemSize", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 KnowledgeReserve
        {
            get { return GetPropertyValue<Int64>("KnowledgeReserve"); }
            set { SetPropertyValue("KnowledgeReserve", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 ResourceEcology
        {
            get { return GetPropertyValue<Int64>("ResourceEcology"); }
            set { SetPropertyValue("ResourceEcology", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 LearnMethod
        {
            get { return GetPropertyValue<Int64>("LearnMethod"); }
            set { SetPropertyValue("LearnMethod", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 Dispersion
        {
            get { return GetPropertyValue<Int64>("Dispersion"); }
            set { SetPropertyValue("Dispersion", value); }
        }

        public Int64 SummaryScope
        {
            get { return GetPropertyValue<Int64>("SummaryScope"); }
            set { SetPropertyValue("SummaryScope", value); }
        }
    }

    [Table("[TB_TechniqueEvaluation]", DbType.Sqlite)]
    public class TB_TechniqueEvaluationSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_TechniqueEvaluation]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_TechniqueEvaluation]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_TechniqueEvaluation]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase TechniqueID = new FieldBase(DbType.Sqlite, "[TB_TechniqueEvaluation]", FieldType.Common, "[TechniqueID]");
        public static readonly FieldBase JobRelation = new FieldBase(DbType.Sqlite, "[TB_TechniqueEvaluation]", FieldType.Common, "[JobRelation]");
        public static readonly FieldBase IndustryRelation = new FieldBase(DbType.Sqlite, "[TB_TechniqueEvaluation]", FieldType.Common, "[IndustryRelation]");
        public static readonly FieldBase TargetDefinition = new FieldBase(DbType.Sqlite, "[TB_TechniqueEvaluation]", FieldType.Common, "[TargetDefinition]");
        public static readonly FieldBase Technique = new FieldBase(DbType.Sqlite, "[TB_TechniqueEvaluation]", FieldType.Common, "[Technique]");
        public static readonly FieldBase SystemSize = new FieldBase(DbType.Sqlite, "[TB_TechniqueEvaluation]", FieldType.Common, "[SystemSize]");
        public static readonly FieldBase KnowledgeReserve = new FieldBase(DbType.Sqlite, "[TB_TechniqueEvaluation]", FieldType.Common, "[KnowledgeReserve]");
        public static readonly FieldBase ResourceEcology = new FieldBase(DbType.Sqlite, "[TB_TechniqueEvaluation]", FieldType.Common, "[ResourceEcology]");
        public static readonly FieldBase LearnMethod = new FieldBase(DbType.Sqlite, "[TB_TechniqueEvaluation]", FieldType.Common, "[LearnMethod]");
        public static readonly FieldBase Dispersion = new FieldBase(DbType.Sqlite, "[TB_TechniqueEvaluation]", FieldType.Common, "[Dispersion]");
        public static readonly FieldBase SummaryScope = new FieldBase(DbType.Sqlite, "[TB_TechniqueEvaluation]", FieldType.Common, "[SummaryScope]");
    }

}
