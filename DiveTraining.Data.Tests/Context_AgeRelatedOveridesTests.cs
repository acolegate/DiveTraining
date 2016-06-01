using System.Diagnostics.CodeAnalysis;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiveTraining.Data.Tests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class Context_AgeRelatedOveridesTests
    {
        [TestMethod]
        public void Context_AgeRelatedOverrides_GetCount_ReturnsCorrectNumber()
        {
            Assert.AreEqual(4, Context.AgeRelatedOverrides.Count, "Unexpected number of age related overrides present");
        }
    }
}