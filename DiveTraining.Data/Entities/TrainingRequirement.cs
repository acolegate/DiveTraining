using System.Collections.Generic;

namespace DiveTraining.Data.Entities
{
    public class TrainingRequirement
    {
        public WaterTypes? WaterTypes { get; set; }
        public string WaterTypeNote { get; set; }
        public int? MinRequiredDives { get; set; }
        public int? MaxRequiredDives { get; set; }
        public string Ratio { get; set; }
        public string RatioNote { get; set; }
        public string DivesNote { get; set; }
    }
}