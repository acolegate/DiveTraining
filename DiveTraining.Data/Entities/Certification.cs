using System.Collections.Generic;

namespace DiveTraining.Data.Entities
{
    public class Certification
    {
        public Certification()
        {
            TrainingRequirements = new List<TrainingRequirement>();
            MinInstructorRatings = new List<Certification>();
            PrerequisiteCertifications = new List<Certification>();
        }

        public string Name { get; set; }

        public CertificationType CertificationType { get; set; }

        public List<TrainingRequirement> TrainingRequirements { get; set; }

        public List<Certification> MinInstructorRatings { get; set; }

        public List<Certification> PrerequisiteCertifications { get; set; }
    }
}