using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

using DiveTraining.Data.Entities;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiveTraining.Data.Tests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class Context_KeyStandardsTests
    {
        [TestMethod]
        public void Context_KeyStandards_GetCount_ReturnsCorrectNumber()
        {
            Assert.AreEqual(71, Context.KeyStandards.Count, "Unexpected number of Key Standards present");
        }

        private bool CheckQualification(List<Certification> prereq, Certification current)
        {
            if (prereq == null || prereq.Any() == false)
            {
                return true;
            }
            else
            {
                if (prereq.Contains(current))
                {
                    return true;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}