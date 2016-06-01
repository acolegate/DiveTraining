using System.Collections.Generic;

using DiveTraining.Data.Entities;

namespace DiveTraining.Data
{
    internal class SetupData
    {
        public static List<KeyStandard> SetupKeyStandardData()
        {
            return new List<KeyStandard>
                       {
                           new KeyStandard
                               {
                                   Certification = Certifications.EfrPrimaryCare,
                                   MinRequiredHours = 4,
                                   MaxRequiredHours = 8,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 Ratio = "12:1:1",
                                                                 RatioNote = RatioNote_12studentsTo1InstructorAnd1Mannequin,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.EfrInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.SecondaryCareFirstAid,
                                   MinRequiredHours = 2,
                                   MaxRequiredHours = 4,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 Ratio = "12:1:1",
                                                                 RatioNote = RatioNote_12studentsTo1InstructorAnd1Mannequin,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.EfrInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.DiscoverSnorkeling,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.GuidedSnorkeling,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.Divemaster
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.SkinDiver,
                                   MinAge = 8,
                                   MinRequiredHours = 12,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.ConfinedWater,
                                                                 RatioNote = RatioNote_1SkinDiveRecommended,
                                                                 Ratio = "16:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.Divemaster
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.PadiSealTeam,
                                   MinAge = 8,
                                   MinRequiredHours = 2,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.Pool,
                                                                 WaterTypeNote = WaterTypeNote_LessThan2m,
                                                                 Ratio = "6:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.PadiSealTeam,
                                   MinAge = 8,
                                   MinRequiredHours = 2,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.Pool,
                                                                 WaterTypeNote = WaterTypeNote_LessThan2m,
                                                                 Ratio = "4:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.AssistantInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.PadiSealTeam,
                                   MinAge = 8,
                                   MinRequiredHours = 2,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.Pool,
                                                                 WaterTypeNote = WaterTypeNote_2to4m,
                                                                 Ratio = "2:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor,
                                                                  Certifications.AssistantInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.Bubblemaker,
                                   MinAge = 8,
                                   MinRequiredHours = 1,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.Pool,
                                                                 Ratio = "6:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.Bubblemaker,
                                   MinAge = 8,
                                   MinRequiredHours = 1,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.Pool,
                                                                 Ratio = "4:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.AssistantInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.Bubblemaker,
                                   MinAge = 8,
                                   MinRequiredHours = 1,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.ConfinedOpenWater,
                                                                 Ratio = "4:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor,
                                                                  Certifications.AssistantInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.DiscoverScubaDiving,
                                   MinAge = 10,
                                   MinRequiredHours = 1,
                                   MaxRequiredHours = 3,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.Pool,
                                                                 Ratio = "8:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor,
                                                                  Certifications.AssistantInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.DiscoverScubaDiving,
                                   MinAge = 10,
                                   MinRequiredHours = 1,
                                   MaxRequiredHours = 3,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.Pool,
                                                                 Ratio = "4:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.DsdLeader
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.DiscoverScubaDiving,
                                   MinAge = 10,
                                   MinRequiredHours = 1,
                                   MaxRequiredHours = 3,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.ConfinedOpenWater,
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                                 Ratio = "4:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor,
                                                                  Certifications.AssistantInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.DiscoverScubaDiving,
                                   MinAge = 10,
                                   MinRequiredHours = 1,
                                   MaxRequiredHours = 3,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.ConfinedOpenWater,
                                                                 Ratio = "2:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.DsdLeader
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.DiscoverScubaDiving,
                                   MinAge = 10,
                                   MinRequiredHours = 1,
                                   MaxRequiredHours = 3,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWaterDescentLine,
                                                                 Ratio = "1:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.DiscoverScubaDiving,
                                   MinAge = 10,
                                   MinRequiredHours = 1,
                                   MaxRequiredHours = 3,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.ConfinedOpenWater,
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                                 Ratio = "4:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor,
                                                                  Certifications.AssistantInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.DiscoverScubaDiving,
                                   MinAge = 10,
                                   MinRequiredHours = 1,
                                   MaxRequiredHours = 3,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                                 Ratio = "4:1",
                                                                 MinRequiredDives = 1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.ReActivate,
                                   MinAge = 13,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.ConfinedWater,
                                                                 Ratio = "10:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.Divemaster
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.JuniorScubaDiver,
                                                                        Certifications.PadiScubaDiver
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.ReActivate,
                                   MinAge = 13,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 Ratio = "18:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.Divemaster
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.JuniorScubaDiver,
                                                                        Certifications.PadiScubaDiver
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.DiscoverLocalDiving,
                                   MinAge = 10,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 MinRequiredDives = 1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.Divemaster
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.JuniorScubaDiver,
                                                                        Certifications.PadiScubaDiver
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.PadiScubaDiver,
                                   MinAge = 15,
                                   MinRequiredHours = 19,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.ConfinedWater,
                                                                 Ratio = "10:1",
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.PadiScubaDiver,
                                   MinAge = 15,
                                   MinRequiredHours = 19,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 MinRequiredDives = 2,
                                                                 Ratio = "10:1",
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                             }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.JuniorScubaDiver,
                                   MinAge = 10,
                                   MinRequiredHours = 19,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.ConfinedWater,
                                                                 Ratio = "10:1",
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.JuniorScubaDiver,
                                   MinAge = 10,
                                   MinRequiredHours = 19,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 MinRequiredDives = 2,
                                                                 Ratio = "10:1",
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.OpenWaterDiver,
                                   MinAge = 15,
                                   MinRequiredHours = 31,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.ConfinedWater,
                                                                 Ratio = "10:1",
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.OpenWaterDiver,
                                   MinAge = 15,
                                   MinRequiredHours = 31,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 MinRequiredDives = 4,
                                                                 DivesNote = DiveNote_OptionalSkinDiveRecommended,
                                                                 Ratio = "8:1",
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.JuniorOpenWaterDiver,
                                   MinAge = 10,
                                   MinRequiredHours = 31,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.ConfinedWater,
                                                                 Ratio = "10:1",
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.JuniorOpenWaterDiver,
                                   MinAge = 10,
                                   MinRequiredHours = 31,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 MinRequiredDives = 4,
                                                                 DivesNote = DiveNote_OptionalSkinDiveRecommended,
                                                                 Ratio = "8:1",
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.AdventureDiver,
                                   MinAge = 15,
                                   MinRequiredHours = 9,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 MinRequiredDives = 3,
                                                                 Ratio = "8:1",
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.OpenWaterDiver
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.JuniorAdventureDiver,
                                   MinAge = 10,
                                   MinRequiredHours = 9,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 MinRequiredDives = 3,
                                                                 Ratio = "8:1",
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.JuniorOpenWaterDiver
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.AdvancedOpenWaterDiver,
                                   MinAge = 15,
                                   MinRequiredHours = 15,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 MinRequiredDives = 5,
                                                                 Ratio = "8:1",
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.OpenWaterDiver
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.JuniorAdvancedOpenWaterDiver,
                                   MinAge = 12,
                                   MinRequiredHours = 15,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 MinRequiredDives = 5,
                                                                 Ratio = "8:1",
                                                                 RatioNote = RatioNote_10To11YearOldsMaximumRatio4To1,
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.JuniorOpenWaterDiver
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.RescueDiver,
                                   MinAge = 15,
                                   MinRequiredHours = 25,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 DivesNote = DivesNote_10Exercises2Scenarios,
                                                                 Ratio = "8:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.AdventureDiver
                                                                    },
                                   PrerequisiteCertificationNote = PrerequisiteCertificationNote_WithUnderwaterNavigation
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.JuniorRescueDiver,
                                   MinAge = 12,
                                   MinRequiredHours = 25,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 WaterTypes = WaterTypes.OpenWater,
                                                                 DivesNote = DivesNote_10Exercises2Scenarios,
                                                                 Ratio = "8:1",
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.JuniorAdventureDiver
                                                                    },
                                   PrerequisiteCertificationNote = PrerequisiteCertificationNote_WithUnderwaterNavigation
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.MasterScubaDiver,
                                   MinAge = 15,
                                   //TrainingRequirement = new TrainingRequirement
                                   //                          {
                                   //                          },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.AdvancedOpenWaterDiver,
                                                                        Certifications.RescueDiver
                                                                    },
                                   PrerequisiteCertificationNote = PrerequisiteCertificationNote_And5PadiSpecialitiesOrTecRecCourses
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.JuniorMasterScubaDiver,
                                   MinAge = 12,
                                   //TrainingRequirement = new TrainingRequirement
                                   //                          {
                                   //                          },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.JuniorAdvancedOpenWaterDiver,
                                                                        Certifications.JuniorRescueDiver
                                                                    },
                                   PrerequisiteCertificationNote = PrerequisiteCertificationNote_And5PadiSpecialitiesOrTecRecCourses
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.Divemaster,
                                   MinAge = 18,
                                   MinRequiredHours = 50,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 Ratio = "8:1"
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.OpenWaterScubaInstructor
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.AdvancedOpenWaterDiver,
                                                                        Certifications.RescueDiver
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.EfrInstructor,
                                   MinAge = 18,
                                   MinRequiredHours = 16,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 Ratio = "12:1:1",
                                                                 RatioNote = RatioNote_12studentsTo1InstructorAnd1Mannequin
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.EfrInstructorTrainer
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.Efr
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.AssistantInstructor,
                                   MinAge = 18,
                                   MinRequiredHours = 40,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 Ratio = "8:1"
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.IdcStaffInstructor
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.Divemaster
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.OpenWaterScubaInstructor,
                                   MinAge = 18,
                                   MinRequiredHours = 90,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 Ratio = "8:1"
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.CourseDirector
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.Divemaster
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.SpecialtyInstructor,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.CourseDirector
                                                                  //NOTE: By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.AssistantInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.MasterScubaDiverTrainerMsdt,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  //NOTE: By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.OpenWaterScubaInstructor
                                                                        // Instructor with 5 PADI Speciality Instructor ratings
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.GasBlenderInstructorEnrichedAirTrimix,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.GasBlenderInstructorTrainer
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.EnrichedAirSpecialtyInstructor
                                                                        // Certification/experience as an EANx/trimix blender
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.RebreatherInstructor,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.RebreatherInstructorTrainer
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.EnrichedAirSpecialtyInstructor,
                                                                        Certifications.DeepSpecialtyInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.RebreatherInstructor,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.RebreatherInstructorTrainer
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.AdvancedRebreatherDiver
                                                                        // Trained on specific Rebreather/CCR unit
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.TecSidemountInstructor,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.TecSidemountInstructorTrainer
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.EnrichedAirSpecialtyInstructor,
                                                                        Certifications.DeepSpecialtyInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.TecSidemountInstructor,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.TecSidemountInstructorTrainer
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.Tec45
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.TecInstructor,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.TecDeepInstructorTrainer
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.MasterScubaDiverTrainerMsdt,
                                                                        Certifications.EnrichedAirSpecialtyInstructor,
                                                                        Certifications.DeepSpecialtyInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.TecDeepInstructor,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.TecDeepInstructorTrainer
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.MasterScubaDiverTrainerMsdt,
                                                                        Certifications.EnrichedAirSpecialtyInstructor,
                                                                        Certifications.DeepSpecialtyInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.TecTrimixDeepInstructor,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.TecTrimixInstructorTrainer
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.MasterScubaDiverTrainerMsdt,
                                                                        Certifications.TecDeepInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.Tec40CcrInstructor,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.Tec60CcrInstructorTrainer
                                                                  // Trained on specific Rebreather/CCR unit
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.MasterScubaDiverTrainerMsdt,
                                                                        Certifications.EnrichedAirSpecialtyInstructor,
                                                                        Certifications.DeepSpecialtyInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.Tec40CcrInstructor,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.Tec60CcrInstructorTrainer
                                                                  // Trained on specific Rebreather/CCR unit
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.Tec40Ccr
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.Tec60CcrInstructor,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.Tec60CcrInstructorTrainer
                                                                  // Trained on specific Rebreather/CCR unit
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.Tec40CcrInstructor,
                                                                        Certifications.Tec60Ccr
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.Tec100CcrInstructor,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.Tec100CcrInstructorTrainer
                                                                  // Trained on specific Rebreather/CCR unit
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.Tec60CcrInstructor,
                                                                        Certifications.Tec100Ccr
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.IdcStaffInstructor,
                                   MinAge = 18,
                                   MinRequiredHours = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  Certifications.CourseDirector
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.MasterScubaDiverTrainerMsdt
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.MasterInstructor,
                                   MinAge = 20,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.IdcStaffInstructor,
                                                                        Certifications.EfrInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.CourseDirector,
                                   MinAge = 20,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.MasterInstructor,
                                                                        Certifications.EfrInstructorTrainer
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.PadiAlumni,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.Divemaster
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.PadiAlumni,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.AssistantInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.PadiAlumni,
                                   MinAge = 18,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.OpenWaterScubaInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.CourseDirector,
                                   MinAge = 20,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.MasterInstructor,
                                                                        Certifications.EfrInstructorTrainer
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.SpecialtyInstructorTrainer,
                                   MinAge = 20,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.CourseDirector,
                                                                        Certifications.SpecialtyInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.EfrInstructorTrainer,
                                   MinAge = 18,
                                   MinRequiredHours = 8,
                                   TrainingRequirement = new TrainingRequirement
                                                             {
                                                                 Ratio = "12:1:1",
                                                                 RatioNote = RatioNote_12studentsTo1InstructorAnd1Mannequin
                                                             },
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.EfrInstructor,
                                                                        // with teaching experience
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.GasBlenderInstructorTrainer,
                                   MinAge = 20,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.CourseDirector,
                                                                        Certifications.GasBlenderInstructorEnrichedAirTrimix
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.RebreatherInstructorTrainer,
                                   MinAge = 20,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.CourseDirector,
                                                                        Certifications.RebreatherInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.TecSidemountInstructorTrainer,
                                   MinAge = 20,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.CourseDirector,
                                                                        Certifications.TecSidemountInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.TecDeepInstructorTrainer,
                                   MinAge = 20,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.CourseDirector,
                                                                        Certifications.TecDeepInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.TecTrimixInstructorTrainer,
                                   MinAge = 20,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.CourseDirector,
                                                                        Certifications.TecDeepInstructor,
                                                                        Certifications.TecTrimixDeepInstructor
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.Tec40CcrInstructorTrainer,
                                   MinAge = 20,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.CourseDirector,
                                                                        Certifications.Tec40CcrInstructor
                                                                        // Trained on specific Rebreather/CCR unit
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.Tec60CcrInstructorTrainer,
                                   MinAge = 20,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.CourseDirector,
                                                                        Certifications.Tec40CcrInstructorTrainer,
                                                                        Certifications.Tec60CcrInstructor
                                                                        // Trained on specific Rebreather/CCR unit
                                                                    }
                               },
                           new KeyStandard
                               {
                                   Certification = Certifications.Tec100CcrInstructorTrainer,
                                   MinAge = 20,
                                   MinInstructorRatings = new List<Certification>
                                                              {
                                                                  // By application approved or training conducted through PADI Office
                                                              },
                                   PrerequisiteCertifications = new List<Certification>
                                                                    {
                                                                        Certifications.CourseDirector,
                                                                        Certifications.Tec60CcrInstructorTrainer,
                                                                        Certifications.Tec100CcrInstructor
                                                                        // Trained on specific Rebreather/CCR unit
                                                                    }
                               }
                       };
        }

        public static List<AgeRelatedOverride> SetupAgeRelatedOverrideData()
        {
            return new List<AgeRelatedOverride>
                       {
                           new AgeRelatedOverride
                               {
                                   MinAge = 8,
                                   MaxAge = 9,
                                   MaxDepth = 4,
                                   MaxDepthNote = "See individual course guide for Bubblemaker and PADI Seal Team",
                                   ResponsibilityAndRiskForConfinedWaterNote = "Before the program/course, parent/guardian and child completes Bublemaker or PADI Seal Team administrative paperwork as appropriate"
                               },
                           new AgeRelatedOverride
                               {
                                   MinAge = 10,
                                   MaxAge = 11,
                                   MaxDepthNote = "Add up to four more student divers per certified assistant",
                                   ConfinedOpenWaterAndOpenWaterDivesRatio = "4:1",
                                   ConfinedOpenWaterAndOpenWaterDivesRatioNote = "No more than two children ages 10-11 in this group. This ratio can not increase by adding certified assistants",
                                   MaxDepth = 12,
                                   AfterCertificationNote = "Must dive with a parent/guardian or PADI Professional",
                                   AfterCertificationMaxDepth = 12,
                                   ResponsibilityAndRiskForConfinedOpenWaterAndOpenWaterDivesNote = "Before course, parent/guardian and child (1) View Your Risk Management DVD (or review the Youth Diving: Responsibility and Risks Flipchart). (2) Read and sign the Youth Diving: Responsibility and Risks Acknowledgement form."
                               },
                           new AgeRelatedOverride
                               {
                                   MinAge = 12,
                                   MaxAge = 14,
                                   MaxDepthNote = "18 metres for Junior Open Water Divers. 21 metres for Continuing Education",
                                   AfterCertificationNote = "Must dive with a adult certified diver",
                                   ResponsibilityAndRiskNote = "Parent/guardian and child sign administrative forms"
                               },
                           new AgeRelatedOverride
                               {
                                   MinAge = 15,
                                   MaxAge = 17,
                                   ResponsibilityAndRiskNote = "Parent/guardian and child sign administrative forms (if local law defines 'legal age' as older than 18, parent/guardian sign administrative forms up to that age)."
                               }
                       };
        } // ReSharper disable InconsistentNaming
        private const string WaterTypeNote_LessThan2m = "< 2m/6ft";
        private const string WaterTypeNote_2to4m = "2-4m/6-12ft";

        private const string RatioNote_12studentsTo1InstructorAnd1Mannequin = "12 students to 1 instructor and 1 mannequin";
        private const string RatioNote_10To11YearOldsMaximumRatio4To1 = "For any open water or confined open water dive that includes 10-11 year olds, the maximum ratio is 4:1, no more than 2 of the 4 may be age 10 or 11.";
        private const string RatioNote_1SkinDiveRecommended = "1 skin dive recommended";

        private const string DiveNote_OptionalSkinDiveRecommended = "Optional skin dive recommended";
        private const string DivesNote_10Exercises2Scenarios = "10 exercises / 2 scenarios";

        private const string PrerequisiteCertificationNote_WithUnderwaterNavigation = "with Underwater Navigation";
        private const string PrerequisiteCertificationNote_And5PadiSpecialitiesOrTecRecCourses = "and 5 PADI Specialities or TecRec courses";
        // ReSharper restore InconsistentNaming
    }
}