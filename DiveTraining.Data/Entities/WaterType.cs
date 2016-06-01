using System.ComponentModel;

namespace DiveTraining.Data.Entities
{
    public enum WaterTypes
    {
        [Description("Guided snorkeling")]
        GuidedSnorkeling,

        [Description("Confined Water")]
        ConfinedWater,

        [Description("Pool")]
        Pool,

        [Description("Confined Open Water")]
        ConfinedOpenWater,

        [Description("Open water - descent line")]
        OpenWaterDescentLine,

        [Description("Open water")]
        OpenWater
    }
}