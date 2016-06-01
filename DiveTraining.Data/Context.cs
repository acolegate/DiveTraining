using System.Collections.Generic;

using DiveTraining.Data.Entities;

namespace DiveTraining.Data
{
    public static class Context
    {
        private static List<KeyStandard> _keyStandardsInstance;
        private static List<AgeRelatedOverride> _ageRelatedOverrides;

        public static List<KeyStandard> KeyStandards
        {
            get { return _keyStandardsInstance ?? (_keyStandardsInstance = SetupData.SetupKeyStandardData()); }
        }

        public static List<AgeRelatedOverride> AgeRelatedOverrides
        {
            get { return _ageRelatedOverrides ?? (_ageRelatedOverrides = SetupData.SetupAgeRelatedOverrideData()); }
        }
    }
}