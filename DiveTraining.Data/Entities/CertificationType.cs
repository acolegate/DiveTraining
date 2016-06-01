using System.ComponentModel;

namespace DiveTraining.Data.Entities
{
    public enum CertificationType
    {
        [Description("Emergency First Response®")]
        EmergencyFirstResponse,

        [Description("Diver Training")]
        DiverTraining,

        [Description("Specialty")]
        Specialty,

        [Description("PADI Tec-Rec")]
        PadiTecRec,

        [Description("PADI Membership")]
        PadiMembership,

        [Description("PADI Instructor Trainer")]
        PadiInstructorTrainer
    }
}