using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using OfficeAider.Module_Technique.Componet.Enum;
using PS.Plot.FrameBasic.Module_Common.Interface;
using Sign.Module_Technique.Controller;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;

namespace OfficeAider.Module_Technique.View.Form
{
    public partial class Frm_TechniqueEvaluate : DevExpress.XtraEditors.XtraForm, IInitialUI,IValidateInput2
    {
        private RadioGroupHelper rghelper_JobRelation;
        private RadioGroupHelper rghelper_IndustryRelation;
        private RadioGroupHelper rghelper_TargetDefinition;
        private RadioGroupHelper rghelper_TechniqueCalatog;

        private RadioGroupHelper rghelper_SystemSize;
        private RadioGroupHelper rghelper_KnowledgeReserve;
        private RadioGroupHelper rghelper_ResourceEcology;
        private RadioGroupHelper rghelper_LearnMethod;
        private RadioGroupHelper rghelper_Dispersion;

        private TechniqueController techController;
        private TechniqueEvaluationController evaluateController;

        public int CurrentTechID { get; set; }

        public Frm_TechniqueEvaluate()
        {
            InitializeComponent();
        }

        private void UC_TechniqueEvaluate_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }


        public void onCreateComponet()
        {
            rghelper_JobRelation = new RadioGroupHelper(this.rg_jobrelation);
            rghelper_IndustryRelation = new RadioGroupHelper(this.rg_industryrelation);
            rghelper_TargetDefinition = new RadioGroupHelper(this.rg_target);
            rghelper_TechniqueCalatog = new RadioGroupHelper(this.rg_skill);
            
            rghelper_SystemSize = new RadioGroupHelper(this.rg_size);
            rghelper_KnowledgeReserve = new RadioGroupHelper(this.rg_reserve);
            rghelper_ResourceEcology = new RadioGroupHelper(this.rg_ecology);
            rghelper_LearnMethod = new RadioGroupHelper(this.rg_method);
            rghelper_Dispersion = new RadioGroupHelper(this.rg_dest);

            techController = new TechniqueController();
            evaluateController = new TechniqueEvaluationController();

            techController.CurrentID = CurrentTechID;
            evaluateController.CurrentID = CurrentTechID;
        }

        public void onInitialUI()
        {
            rghelper_JobRelation.FillRadioButtonByEnum(JobRelation.Coincidence);
            rghelper_IndustryRelation.FillRadioButtonByEnum(IndustryRelation.Core);
            rghelper_TargetDefinition.FillRadioButtonByEnum(TargetDefinition.Explicit);
            rghelper_TechniqueCalatog.FillRadioButtonByEnum(TechniqueCalatog.Application);

            rghelper_SystemSize.FillRadioButtonByEnum(SystemSize.Moderate);
            rghelper_KnowledgeReserve.FillRadioButtonByEnum(KnowledgeReserve.Concept);
            rghelper_ResourceEcology.FillRadioButtonByEnum(ResourceEcology.Book);
            rghelper_LearnMethod.FillRadioButtonByEnum(LearnMethod.Comprehensiveness);
            rghelper_Dispersion.FillRadioButtonByEnum(Dispersion.Normal);

            tv_Desription.Text = "";
            tv_Name.Text = "";
            dateE_Create.DateTime = DateTime.Now.Date;
            spinE_Interest.Value = 50;
            cmb_catalog.Properties.Items.Clear();
            cmb_catalog.Properties.Items.AddRange(new TechniqueCatalogController().TravleAllEntities().ToList());

            techController.LoadEntry();
            evaluateController.LoadEntry();

            if (CurrentTechID != 0)
            {

                tv_Desription.Text = techController.Entry.Description;
                tv_Name.Text = techController.Entry.Name;
                dateE_Create.DateTime = DateTime.Parse(techController.Entry.CreateDate);
                spinE_Interest.Value = techController.Entry.Interest;

              

                rghelper_JobRelation.SelectItemByEnumValue(evaluateController.Entry.JobRelation);
                rghelper_IndustryRelation.SelectItemByEnumValue(evaluateController.Entry.IndustryRelation);
                rghelper_TargetDefinition.SelectItemByEnumValue(evaluateController.Entry.TargetDefinition);
                rghelper_TechniqueCalatog.SelectItemByEnumValue(evaluateController.Entry.Technique);

                rghelper_SystemSize.SelectItemByEnumValue(evaluateController.Entry.SystemSize);
                rghelper_KnowledgeReserve.SelectItemByEnumValue(evaluateController.Entry.KnowledgeReserve);
                rghelper_ResourceEcology.SelectItemByEnumValue(evaluateController.Entry.ResourceEcology);
                rghelper_LearnMethod.SelectItemByEnumValue(evaluateController.Entry.LearnMethod);
                rghelper_Dispersion.SelectItemByEnumValue(evaluateController.Entry.Dispersion);

                btn_evaluate.Text = "重新评估";
                btn_Create.Text = "修改记录";
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Validator validator = onValidateInputValue();
            if (validator.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
                return;
            }

            onExtractInputValue();

            if (evaluateController.Entry.SummaryScope <= 0)
            {
                MessageBoxHelper.ShowInputErrorDialog("请先进行分值评估");
                return;
            }

            object newPK;
            if (techController.InsertEntry(out newPK))
            {
                evaluateController.Entry.TechniqueID = long.Parse(newPK.ToString());
                MessageBoxHelper.ShowSaveStateDialog(evaluateController.InsertEntry());
            }
            else
                MessageBoxHelper.ShowErrorDialog("创建技术记录失败...");
            
        }

        private void btn_evaluate_Click(object sender, EventArgs e)
        {
            onExtractInputValue();

            //执行评估

            //评估赋值
            evaluateController.Entry.SummaryScope = 0;
        }

        public void onExtractInputValue()
        {
            techController.Entry.Name = tv_Name.Text;
            techController.Entry.Description = tv_Desription.Text;
            techController.Entry.CreateDate = techController.FormatDate(dateE_Create.DateTime.Date);
            techController.Entry.Interest = (long)spinE_Interest.Value;
            techController.Entry.CatalogID = TechniqueCatalogController.ExtractID(cmb_catalog.SelectedItem);

            evaluateController.Entry.Dispersion = rghelper_Dispersion.GetSelectItemValue();
            evaluateController.Entry.IndustryRelation = rghelper_IndustryRelation.GetSelectItemValue();
            evaluateController.Entry.TargetDefinition = rghelper_TargetDefinition.GetSelectItemValue();
            evaluateController.Entry.Technique = rghelper_TechniqueCalatog.GetSelectItemValue();
            evaluateController.Entry.SystemSize = rghelper_SystemSize.GetSelectItemValue();
            evaluateController.Entry.KnowledgeReserve = rghelper_KnowledgeReserve.GetSelectItemValue();
            evaluateController.Entry.ResourceEcology = rghelper_ResourceEcology.GetSelectItemValue();
            evaluateController.Entry.LearnMethod = rghelper_LearnMethod.GetSelectItemValue();
            evaluateController.Entry.JobRelation = rghelper_JobRelation.GetSelectItemValue();
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(tv_Name.Text, "技术名称");
            return validator;
        }
    }
}
