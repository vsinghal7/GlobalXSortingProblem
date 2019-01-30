using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlobalXSortingProblem;
using System.Collections.Generic;

namespace GlobalXSortingProblemTests
{
    [TestClass]
    public class GlobalXSortingProblemTests
    {
        [TestMethod]
        public void GetSortedNamesTests_1()
        {
            INameSorting nameSorting = new NameSorting();
            List<string> testNames = new List<string>();

            testNames.Add("Vinod Singhal");
            testNames.Add("Vinod Kumar Singhal");
            testNames.Add("Vinod James Kumar Singhal");
            testNames.Add("Vinod Kumar");
            testNames.Add("Vinod Jameson");
            testNames.Add("Vinod Kumar Jameson");
            testNames.Add("Vinod James Kumar");
            testNames.Add("Vinod Henkels Vinod");
            testNames.Add("Vinod Vinod Vinod");

            var result = nameSorting.GetSortedNames(testNames);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, testNames.Count);

        }
    }
}
