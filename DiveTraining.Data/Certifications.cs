using System.Collections.Generic;

using DiveTraining.Data.Entities;

namespace DiveTraining.Data
{
    public static class Certifications
    {
        #region Emergency First Response

        public static Certification Efr { get; } = new Certification
                                                       {
                                                           Name = "Emergency First Response®",
                                                           CertificationType = CertificationType.EmergencyFirstResponse
                                                       };

        #endregion

        #region Diver Training

        public static Certification EfrPrimaryCare { get; } = new Certification
                                                                  {
                                                                      Name = "Emergency First Response® Primary Care (CPR)",
                                                                      CertificationType = CertificationType.DiverTraining
                                                                  };

        public static Certification SecondaryCareFirstAid { get; } = new Certification
                                                                         {
                                                                             Name = "Secondary Care (First Aid)",
                                                                             CertificationType = CertificationType.DiverTraining
                                                                         };

        public static Certification DiscoverSnorkeling { get; } = new Certification
                                                                      {
                                                                          Name = "Discover Snorkeling",
                                                                          CertificationType = CertificationType.DiverTraining,
                                                                      };

        public static Certification SkinDiver { get; } = new Certification
                                                             {
                                                                 Name = "Skin Diver",
                                                                 CertificationType = CertificationType.DiverTraining,
                                                             };

        public static Certification PadiSealTeam { get; } = new Certification
                                                                {
                                                                    Name = "PADI Seal Team",
                                                                    CertificationType = CertificationType.DiverTraining,
                                                                };

        public static Certification Bubblemaker { get; } = new Certification
                                                               {
                                                                   Name = "Bubblemaker",
                                                                   CertificationType = CertificationType.DiverTraining,
                                                               };

        public static Certification DiscoverScubaDiving { get; } = new Certification
                                                                       {
                                                                           Name = "Discover Scuba Diving",
                                                                           CertificationType = CertificationType.DiverTraining,
                                                                       };

        public static Certification ReActivate { get; } = new Certification
                                                              {
                                                                  Name = "ReActivate",
                                                                  CertificationType = CertificationType.DiverTraining,
                                                              };

        public static Certification DiscoverLocalDiving { get; } = new Certification
                                                                       {
                                                                           Name = "Discover Local Diving",
                                                                           CertificationType = CertificationType.DiverTraining,
                                                                       };

        public static Certification PadiScubaDiver { get; } = new Certification
                                                                  {
                                                                      Name = "PADI Scuba Diver",
                                                                      CertificationType = CertificationType.DiverTraining,
                                                                  };

        public static Certification JuniorScubaDiver { get; } = new Certification
                                                                    {
                                                                        Name = "Junior Scuba Diver",
                                                                        CertificationType = CertificationType.DiverTraining,
                                                                    };

        public static Certification OpenWaterDiver { get; } = new Certification
                                                                  {
                                                                      Name = "Open Water Diver",
                                                                      CertificationType = CertificationType.DiverTraining,
                                                                  };

        public static Certification JuniorOpenWaterDiver { get; } = new Certification
                                                                        {
                                                                            Name = "Junior Open Water Diver",
                                                                            CertificationType = CertificationType.DiverTraining,
                                                                        };

        public static Certification AdventureDiver { get; } = new Certification
                                                                  {
                                                                      Name = "Adventure Diver",
                                                                      CertificationType = CertificationType.DiverTraining,
                                                                  };

        public static Certification JuniorAdventureDiver { get; } = new Certification
                                                                        {
                                                                            Name = "Junior Adventure Diver",
                                                                            CertificationType = CertificationType.DiverTraining,
                                                                        };

        public static Certification AdvancedOpenWaterDiver { get; } = new Certification
                                                                          {
                                                                              Name = "Advanced Open Water Diver",
                                                                              CertificationType = CertificationType.DiverTraining,
                                                                          };

        public static Certification JuniorAdvancedOpenWaterDiver { get; } = new Certification
                                                                                {
                                                                                    Name = "Junior Advanced Open Water Diver",
                                                                                    CertificationType = CertificationType.DiverTraining,
                                                                                };

        public static Certification RescueDiver { get; } = new Certification
                                                               {
                                                                   Name = "Rescue Diver",
                                                                   CertificationType = CertificationType.DiverTraining,
                                                               };

        public static Certification JuniorRescueDiver { get; } = new Certification
                                                                     {
                                                                         Name = "Junior Rescue Diver",
                                                                         CertificationType = CertificationType.DiverTraining,
                                                                     };

        public static Certification MasterScubaDiver { get; } = new Certification
                                                                    {
                                                                        Name = "Master Scuba Diver",
                                                                        CertificationType = CertificationType.DiverTraining,
                                                                    };

        public static Certification JuniorMasterScubaDiver { get; } = new Certification
                                                                          {
                                                                              Name = "Junior Master Scuba Diver",
                                                                              CertificationType = CertificationType.DiverTraining,
                                                                          };

        #endregion

        #region Specialities

        public static Certification AltitudeDiver { get; } = new Certification
                                                                 {
                                                                     Name = "Altitude Diver",
                                                                     CertificationType = CertificationType.Specialty,
                                                                 };

        public static Certification AwareCoralReefConservation { get; } = new Certification
                                                                              {
                                                                                  Name = "AWARE - Coral Reef Conservation",
                                                                                  CertificationType = CertificationType.Specialty,
                                                                              };

        public static Certification AwareFishIdentificationDiver { get; } = new Certification
                                                                                {
                                                                                    Name = "AWARE - Fish Identification Diver",
                                                                                    CertificationType = CertificationType.Specialty,
                                                                                };

        public static Certification AwareSharkConservationDiverDistinctive { get; } = new Certification
                                                                                          {
                                                                                              Name = "AWARE – Shark Conservation Diver (distinctive)",
                                                                                              CertificationType = CertificationType.Specialty,
                                                                                          };

        public static Certification BoatDiver { get; } = new Certification
                                                             {
                                                                 Name = "Boat Diver",
                                                                 CertificationType = CertificationType.Specialty,
                                                             };

        public static Certification CavernDiver { get; } = new Certification
                                                               {
                                                                   Name = "Cavern Diver",
                                                                   CertificationType = CertificationType.Specialty,
                                                               };

        public static Certification DeepDiver { get; } = new Certification
                                                             {
                                                                 Name = "Deep Diver",
                                                                 CertificationType = CertificationType.Specialty,
                                                             };

        public static Certification DigitalUnderwaterPhotographer { get; } = new Certification
                                                                                 {
                                                                                     Name = "Digital Underwater Photographer",
                                                                                     CertificationType = CertificationType.Specialty,
                                                                                 };

        public static Certification DiverPropulsionVehicleDpvDiver { get; } = new Certification
                                                                                  {
                                                                                      Name = "Diver Propulsion Vehicle (DPV) Diver",
                                                                                      CertificationType = CertificationType.Specialty,
                                                                                  };

        public static Certification DriftDiver { get; } = new Certification
                                                              {
                                                                  Name = "Drift Diver",
                                                                  CertificationType = CertificationType.Specialty,
                                                              };

        public static Certification DrySuitDiver { get; } = new Certification
                                                                {
                                                                    Name = "Dry Suit Diver",
                                                                    CertificationType = CertificationType.Specialty,
                                                                };

        public static Certification EnrichedAirDiver { get; } = new Certification
                                                                    {
                                                                        Name = "Enriched Air Diver",
                                                                        CertificationType = CertificationType.Specialty,
                                                                    };

        public static Certification EmergencyOxygenProvider { get; } = new Certification
                                                                           {
                                                                               Name = "Emergency Oxygen Provider",
                                                                               CertificationType = CertificationType.Specialty,
                                                                           };

        public static Certification EquipmentSpecialist { get; } = new Certification
                                                                       {
                                                                           Name = "Equipment Specialist",
                                                                           CertificationType = CertificationType.Specialty,
                                                                       };

        public static Certification IceDiver { get; } = new Certification
                                                            {
                                                                Name = "Ice Diver",
                                                                CertificationType = CertificationType.Specialty,
                                                            };

        public static Certification MultilevelDiver { get; } = new Certification
                                                                   {
                                                                       Name = "Multilevel Diver",
                                                                       CertificationType = CertificationType.Specialty
                                                                   };

        public static Certification NightDiver { get; } = new Certification
                                                              {
                                                                  Name = "Night Diver",
                                                                  CertificationType = CertificationType.Specialty
                                                              };

        public static Certification PeakPerformanceBuoyancy { get; } = new Certification
                                                                           {
                                                                               Name = "Peak Performance Buoyancy",
                                                                               CertificationType = CertificationType.Specialty
                                                                           };

        public static Certification ProjectAwareSpecialist { get; } = new Certification
                                                                          {
                                                                              Name = "Project AWARE Specialist",
                                                                              CertificationType = CertificationType.Specialty,
                                                                          };

        public static Certification PublicSafetyDiver { get; } = new Certification
                                                                     {
                                                                         Name = "Public Safety Diver™",
                                                                         CertificationType = CertificationType.Specialty,
                                                                         PrerequisiteCertifications = new List<Certification>
                                                                                                          {
                                                                                                              AdvancedOpenWaterDiver
                                                                                                          }
                                                                     };

        public static Certification SearchAndRecoveryDiver { get; } = new Certification
                                                                          {
                                                                              Name = "Search & Recovery Diver",
                                                                              CertificationType = CertificationType.Specialty,
                                                                          };

        public static Certification SemiclosedRebreatherDiverDolphinAtlantis { get; } = new Certification
                                                                                            {
                                                                                                Name = "Semiclosed Rebreather Diver (Dolphin/Atlantis)",
                                                                                                CertificationType = CertificationType.Specialty,
                                                                                            };

        public static Certification SidemountDiver { get; } = new Certification
                                                                  {
                                                                      Name = "Sidemount Diver",
                                                                      CertificationType = CertificationType.Specialty,
                                                                  };

        public static Certification UnderwaterNaturalist { get; } = new Certification
                                                                        {
                                                                            Name = "Underwater Naturalist",
                                                                            CertificationType = CertificationType.Specialty,
                                                                        };

        public static Certification UnderwaterNavigator { get; } = new Certification
                                                                       {
                                                                           Name = "Underwater Navigator",
                                                                           CertificationType = CertificationType.Specialty,
                                                                       };

        public static Certification UnderwaterPhotographer { get; } = new Certification
                                                                          {
                                                                              Name = "Underwater Photographer",
                                                                              CertificationType = CertificationType.Specialty,
                                                                          };

        public static Certification UnderwaterVideographer { get; } = new Certification
                                                                          {
                                                                              Name = "Underwater Videographer",
                                                                              CertificationType = CertificationType.Specialty,
                                                                          };

        public static Certification WreckDiver { get; } = new Certification
                                                              {
                                                                  Name = "Wreck Diver",
                                                                  CertificationType = CertificationType.Specialty,
                                                              };

        #endregion

        #region PADI TecRec

        public static Certification GasBlender { get; } = new Certification
                                                              {
                                                                  Name = "Gas Blender",
                                                                  CertificationType = CertificationType.PadiTecRec,
                                                                  PrerequisiteCertifications = new List<Certification>
                                                                                                   {
                                                                                                       EnrichedAirDiver
                                                                                                   }
                                                              };

        public static Certification Tec40 { get; } = new Certification
                                                         {
                                                             Name = "Tec 40",
                                                             CertificationType = CertificationType.PadiTecRec
                                                         };

        public static Certification Tec45 { get; } = new Certification
                                                         {
                                                             Name = "Tec 45",
                                                             CertificationType = CertificationType.PadiTecRec
                                                         };

        public static Certification Tec50 { get; } = new Certification
                                                         {
                                                             Name = "Tec 50",
                                                             CertificationType = CertificationType.PadiTecRec
                                                         };

        public static Certification TecTrimix65 { get; } = new Certification
                                                               {
                                                                   Name = "Tec Trimix 65",
                                                                   CertificationType = CertificationType.PadiTecRec
                                                               };

        public static Certification TecTrimix { get; } = new Certification
                                                             {
                                                                 Name = "tecTrimix",
                                                                 CertificationType = CertificationType.PadiTecRec
                                                             };

        public static Certification RebreatherDiver { get; } = new Certification
                                                                   {
                                                                       Name = "Rebreather Diver",
                                                                       CertificationType = CertificationType.PadiTecRec
                                                                   };

        public static Certification AdvancedRebreatherDiver { get; } = new Certification
                                                                           {
                                                                               Name = "Advanced Rebreather Diver",
                                                                               CertificationType = CertificationType.PadiTecRec,
                                                                           };

        public static Certification TecSidemount { get; } = new Certification
                                                                {
                                                                    Name = "Tec Sidemount",
                                                                    CertificationType = CertificationType.PadiTecRec
                                                                };

        public static Certification Tec40Ccr { get; } = new Certification
                                                            {
                                                                Name = "Tec 40 CCR",
                                                                CertificationType = CertificationType.PadiTecRec
                                                            };

        public static Certification Tec60Ccr { get; } = new Certification
                                                            {
                                                                Name = "Tec 60 CCR",
                                                                CertificationType = CertificationType.PadiTecRec
                                                            };

        public static Certification Tec100Ccr { get; } = new Certification
                                                             {
                                                                 Name = "Tec 100 CCR",
                                                                 CertificationType = CertificationType.PadiTecRec
                                                             };

        #endregion

        #region PADI Membership

        public static Certification Divemaster { get; } = new Certification
                                                              {
                                                                  Name = "Divemaster",
                                                                  CertificationType = CertificationType.PadiMembership
                                                              };

        public static Certification DsdLeader { get; } = new Certification
                                                             {
                                                                 Name = "DSD Leader",
                                                                 CertificationType = CertificationType.PadiMembership
                                                             };

        public static Certification EfrInstructor { get; } = new Certification
                                                                 {
                                                                     Name = "EFR Instructor",
                                                                     CertificationType = CertificationType.PadiMembership
                                                                 };

        public static Certification AssistantInstructor { get; } = new Certification
                                                                       {
                                                                           Name = "Assistant Instructor",
                                                                           CertificationType = CertificationType.PadiMembership,
                                                                       };

        public static Certification OpenWaterScubaInstructor { get; } = new Certification
                                                                            {
                                                                                Name = "Open Water Scuba Instructor",
                                                                                CertificationType = CertificationType.PadiMembership,
                                                                            };

        public static Certification SpecialtyInstructor { get; } = new Certification
                                                                       {
                                                                           Name = "Specialty Instructor",
                                                                           CertificationType = CertificationType.PadiMembership,
                                                                       };

        public static Certification EnrichedAirSpecialtyInstructor { get; } = new Certification
                                                                                  {
                                                                                      Name = "Enriched Air Specialty Instructor",
                                                                                      CertificationType = CertificationType.PadiMembership,
                                                                                  };

        public static Certification DeepSpecialtyInstructor { get; } = new Certification
                                                                           {
                                                                               Name = "Deep Specialty Instructor",
                                                                               CertificationType = CertificationType.PadiMembership,
                                                                           };

        public static Certification MasterScubaDiverTrainerMsdt { get; } = new Certification
                                                                               {
                                                                                   Name = "Master Scuba Diver Trainer (MSDT)",
                                                                                   CertificationType = CertificationType.PadiMembership,
                                                                               };

        public static Certification GasBlenderInstructorEnrichedAirTrimix { get; } = new Certification
                                                                                         {
                                                                                             Name = "Gas Blender Instructor - Enriched Air (- Trimix)",
                                                                                             CertificationType = CertificationType.PadiMembership
                                                                                         };

        public static Certification RebreatherInstructor { get; } = new Certification
                                                                        {
                                                                            Name = "Rebreather Instructor",
                                                                            CertificationType = CertificationType.PadiMembership
                                                                        };

        public static Certification TecSidemountInstructor { get; } = new Certification
                                                                          {
                                                                              Name = "Tec Sidemount Instructor",
                                                                              CertificationType = CertificationType.PadiMembership
                                                                          };

        public static Certification TecInstructor { get; } = new Certification
                                                                 {
                                                                     Name = "Tec Instructor",
                                                                     CertificationType = CertificationType.PadiMembership
                                                                 };

        public static Certification TecDeepInstructor { get; } = new Certification
                                                                     {
                                                                         Name = "Tec Deep Instructor",
                                                                         CertificationType = CertificationType.PadiMembership
                                                                     };

        public static Certification TecTrimixDeepInstructor { get; } = new Certification
                                                                           {
                                                                               Name = "Tec Trimix Deep Instructor",
                                                                               CertificationType = CertificationType.PadiMembership
                                                                           };

        public static Certification Tec40CcrInstructor { get; } = new Certification
                                                                      {
                                                                          Name = "Tec 40 CCR Instructor",
                                                                          CertificationType = CertificationType.PadiMembership
                                                                      };

        public static Certification Tec60CcrInstructor { get; } = new Certification
                                                                      {
                                                                          Name = "Tec 60 CCR Instructor",
                                                                          CertificationType = CertificationType.PadiMembership
                                                                      };

        public static Certification Tec100CcrInstructor { get; } = new Certification
                                                                       {
                                                                           Name = "Tec 100 CCR Instructor",
                                                                           CertificationType = CertificationType.PadiMembership
                                                                       };

        public static Certification IdcStaffInstructor { get; } = new Certification
                                                                      {
                                                                          Name = "IDC Staff Instructor",
                                                                          CertificationType = CertificationType.PadiMembership,
                                                                      };

        public static Certification MasterInstructor { get; } = new Certification
                                                                    {
                                                                        Name = "Master Instructor",
                                                                        CertificationType = CertificationType.PadiMembership,
                                                                    };

        public static Certification CourseDirector { get; } = new Certification
                                                                  {
                                                                      Name = "Course Director",
                                                                      CertificationType = CertificationType.PadiMembership,
                                                                  };

        public static Certification PadiAlumni { get; } = new Certification
                                                              {
                                                                  Name = "PADI Alumni",
                                                                  CertificationType = CertificationType.PadiMembership
                                                              };

        #endregion

        #region PADI Instructor Trainer

        public static Certification SpecialtyInstructorTrainer { get; } = new Certification
                                                                              {
                                                                                  Name = "Specialty Instructor Trainer",
                                                                                  CertificationType = CertificationType.PadiInstructorTrainer
                                                                              };

        public static Certification EfrInstructorTrainer { get; } = new Certification
                                                                        {
                                                                            Name = "Efr Instructor Trainer",
                                                                            CertificationType = CertificationType.PadiInstructorTrainer
                                                                        };

        public static Certification GasBlenderInstructorTrainer { get; } = new Certification
                                                                               {
                                                                                   Name = "Gas Blender Instructor Trainer",
                                                                                   CertificationType = CertificationType.PadiInstructorTrainer
                                                                               };

        public static Certification RebreatherInstructorTrainer { get; } = new Certification
                                                                               {
                                                                                   Name = "Rebreather Instructor Trainer",
                                                                                   CertificationType = CertificationType.PadiInstructorTrainer
                                                                               };

        public static Certification TecSidemountInstructorTrainer { get; } = new Certification
                                                                                 {
                                                                                     Name = "Tec Sidemount Instructor Trainer",
                                                                                     CertificationType = CertificationType.PadiInstructorTrainer
                                                                                 };

        public static Certification TecDeepInstructorTrainer { get; } = new Certification
                                                                            {
                                                                                Name = "Tec Deep Instructor Trainer",
                                                                                CertificationType = CertificationType.PadiInstructorTrainer
                                                                            };

        public static Certification TecTrimixInstructorTrainer { get; } = new Certification
                                                                              {
                                                                                  Name = "Tec Trimix Instructor Trainer",
                                                                                  CertificationType = CertificationType.PadiInstructorTrainer
                                                                              };

        public static Certification Tec40CcrInstructorTrainer { get; } = new Certification
                                                                             {
                                                                                 Name = "Tec 40 CCR Instructor Trainer",
                                                                                 CertificationType = CertificationType.PadiInstructorTrainer
                                                                             };

        public static Certification Tec60CcrInstructorTrainer { get; } = new Certification
                                                                             {
                                                                                 Name = "Tec 60 CCR Instructor Trainer",
                                                                                 CertificationType = CertificationType.PadiInstructorTrainer
                                                                             };

        public static Certification Tec100CcrInstructorTrainer { get; } = new Certification
                                                                              {
                                                                                  Name = "Tec 100 CCR Instructor Trainer",
                                                                                  CertificationType = CertificationType.PadiInstructorTrainer
                                                                              };

        #endregion
    }
}