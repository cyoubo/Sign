using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using Sign.Module_Technique.Model;

namespace Sign.Module_Technique.Componet.Adapter
{
    public class TB_TechniqueEvaluationBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string TechniqueID = "TechniqueID";
        public readonly string JobRelation = "JobRelation";
        public readonly string IndustryRelation = "IndustryRelation";
        public readonly string TargetDefinition = "TargetDefinition";
        public readonly string Technique = "Technique";
        public readonly string SystemSize = "SystemSize";
        public readonly string KnowledgeReserve = "KnowledgeReserve";
        public readonly string ResourceEcology = "ResourceEcology";
        public readonly string LearnMethod = "LearnMethod";
        public readonly string Dispersion = "Dispersion";
        public readonly string SummaryScope = "SummaryScope";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(TechniqueID);
            onCreateDataColumn(JobRelation);
            onCreateDataColumn(IndustryRelation);
            onCreateDataColumn(TargetDefinition);
            onCreateDataColumn(Technique);
            onCreateDataColumn(SystemSize);
            onCreateDataColumn(KnowledgeReserve);
            onCreateDataColumn(ResourceEcology);
            onCreateDataColumn(LearnMethod);
            onCreateDataColumn(Dispersion);
            onCreateDataColumn(SummaryScope);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
        }
    }
    public class TB_TechniqueEvaluationAdapter : BaseGridControlAdapter<TB_TechniqueEvaluation>
    {
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_TechniqueEvaluation t)
        {
            TB_TechniqueEvaluationBuilder targetBuilder = builder as TB_TechniqueEvaluationBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.TechniqueID] = t.TechniqueID.ToString();
            tempRow[targetBuilder.JobRelation] = t.JobRelation.ToString();
            tempRow[targetBuilder.IndustryRelation] = t.IndustryRelation.ToString();
            tempRow[targetBuilder.TargetDefinition] = t.TargetDefinition.ToString();
            tempRow[targetBuilder.Technique] = t.Technique.ToString();
            tempRow[targetBuilder.SystemSize] = t.SystemSize.ToString();
            tempRow[targetBuilder.KnowledgeReserve] = t.KnowledgeReserve.ToString();
            tempRow[targetBuilder.ResourceEcology] = t.ResourceEcology.ToString();
            tempRow[targetBuilder.LearnMethod] = t.LearnMethod.ToString();
            tempRow[targetBuilder.Dispersion] = t.Dispersion.ToString();
            tempRow[targetBuilder.SummaryScope] = t.SummaryScope.ToString();
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
        }
    }
}
