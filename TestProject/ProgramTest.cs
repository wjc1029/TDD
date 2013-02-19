using TDDdemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Sum
        ///</summary>
        [TestMethod()]
        public void SumTest()
        {
            int a = 1; // TODO: Initialize to an appropriate value
            int b = 2; // TODO: Initialize to an appropriate value
            int expect = 3;
            int actual=Program.Sum(a, b);
            Assert.AreEqual(expect, actual);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Sum
        ///</summary>
        [TestMethod()]
        public void SumTest2()
        {
            int a = 0; // TODO: Initialize to an appropriate value
            int b = 2; // TODO: Initialize to an appropriate value
            int expect = 3;
            int actual = Program.Sum(a, b);
            Assert.AreEqual(expect, actual);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
