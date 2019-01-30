using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlobalXSortingProblem;
using System.Collections.Generic;

namespace GlobalXSortingProblemTests
{
    [TestClass]
    public class GlobalXSortingProblemTests
    {
        //If the input list has some name.
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

            var result = nameSorting.WriteSortedNames(testNames);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, testNames.Count);

        }

        //If the input list count is zero
        [TestMethod]
        public void GetSortedNamesTests_2()
        {
            INameSorting nameSorting = new NameSorting();
            List<string> testNames = new List<string>();

            var result = nameSorting.WriteSortedNames(testNames);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 0);

        }

        //If there is an exception
        [TestMethod]
        public void GetSortedNamesTests_3()
        {
            INameSorting nameSorting = new NameSorting();
            List<string> testNames = null;
            try
            {
                var result = nameSorting.WriteSortedNames(testNames);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }

        }
    }
}
