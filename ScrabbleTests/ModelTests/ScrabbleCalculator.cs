using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;

namespace ProjectName.Tests
{
    [TestClass]
    public class ClassNameTests
    {
        // Test methods go here
        [TestMethod]
        public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
        {
        // any necessary logic to prep for test; instantiating new classes, etc.
        // we can also use the arrange, act, assert organization in any test. 
        Assert.AreEqual(ExpectedResult, CodeToTest);
        }
    }
}