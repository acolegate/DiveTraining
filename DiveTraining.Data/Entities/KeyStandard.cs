using System.Collections.Generic;

namespace DiveTraining.Data.Entities
{
    public class KeyStandard
    {
        public KeyStandard()
        {
            MinInstructorRatings = new List<Certification>();
            PrerequisiteCertifications = new List<Certification>();
        }

        public Certification Certification { get; set; }

        public int? MinAge { get; set; }

        public int? MinRequiredHours { get; set; }
        public int? MaxRequiredHours { get; set; }

        public TrainingRequirement TrainingRequirement { get; set; }

        public List<Certification> MinInstructorRatings { get; set; }

        public List<Certification> PrerequisiteCertifications { get; set; }
        public string PrerequisiteCertificationNote { get; set; }
    }
}