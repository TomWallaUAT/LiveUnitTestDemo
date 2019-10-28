using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private string WantThisString = "Live Unit Test Demo";
        private string[] SResults;


        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                LiveUnitTestDemo.Program.Main();

                var valBack = sw.ToString().Trim();
                Assert.AreEqual(WantThisString, valBack);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            SResults = LiveUnitTestDemo.Program.GiveData();
            Assert.IsTrue(SResults.Length > 0);
        }
    }
}
