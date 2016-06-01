namespace DiveTraining.Data.Entities
{
    public class AgeRelatedOverride
    {
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public int? MaxDepth { get; set; }
        public string MaxDepthNote { get; set; }
        public string PoolDivesRatio { get; set; }
        public string PoolDivesRatioNote { get; set; }
        public string ConfinedOpenWaterAndOpenWaterDivesRatio { get; set; }
        public string ConfinedOpenWaterAndOpenWaterDivesRatioNote { get; set; }
        public int? AfterCertificationMaxDepth { get; set; }
        public string AfterCertificationNote { get; set; }
        public string ResponsibilityAndRiskNote { get; set; }
        public string ResponsibilityAndRiskForConfinedWaterNote { get; set; }
        public string ResponsibilityAndRiskForConfinedOpenWaterAndOpenWaterDivesNote { get; set; }
    }
}