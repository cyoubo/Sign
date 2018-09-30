using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeAider.Module_Technique.Componet.Enum
{
    public enum JobRelation
    {
		[DescriptionAttribute("高度重合")]
		Coincidence= 1,
		[DescriptionAttribute("有所涉及")]
		Involve= 2,
		[DescriptionAttribute("单纯兴趣")]
		Interest= 3
	 }

    public enum IndustryRelation
    {
        [DescriptionAttribute("核心技术")]
        Core = 1,
        [DescriptionAttribute("交叉技术")]
        Overlap = 2,
        [DescriptionAttribute("转型技术")]
        Transition = 3
    }

    public enum TargetDefinition
    {
        [DescriptionAttribute("需求明确")]
        Explicit = 1,
        [DescriptionAttribute("缺乏场景")]
        Fuzzy = 2,
        [DescriptionAttribute("承接过渡")]
        Transition = 3
    }

    public enum TechniqueCalatog
    {
        [DescriptionAttribute("辅助工具")]
        Auxiliary = 1,
        [DescriptionAttribute("框架工具")]
        Framework = 2,
        [DescriptionAttribute("应用工具")]
        Application = 3
    }

    public enum SystemSize
    {
        [DescriptionAttribute("庞大")]
        Huge = 1,
        [DescriptionAttribute("适中")]
        Moderate = 2,
        [DescriptionAttribute("精简")]
        Streamlined = 3
    }

    public enum KnowledgeReserve
    {
        [DescriptionAttribute("0基础")]
        No_Foundation = 1,
        [DescriptionAttribute("仅理论概念")]
        Concept = 2,
        [DescriptionAttribute("可简单应用")]
        Application = 3,
        [DescriptionAttribute("可熟练应用")]
        Master = 4
    }

    public enum ResourceEcology
    {
        [DescriptionAttribute("视频教程")]
        Video = 1,
        [DescriptionAttribute("书籍文档")]
        Book = 2,
        [DescriptionAttribute("网络博客")]
        Blog = 3
    }

    public enum LearnMethod
    {
        [DescriptionAttribute("课程式")]
        Course = 1,
        [DescriptionAttribute("应用式")]
        Application = 2,
        [DescriptionAttribute("综合式")]
        Comprehensiveness = 3
    }

    public enum Dispersion
    {
        [DescriptionAttribute("可离散")]
        Successive = 1,
        [DescriptionAttribute("需连续")]
        Discrete = 2,
        [DescriptionAttribute("无要求")]
        Normal = 3 
    }
}
