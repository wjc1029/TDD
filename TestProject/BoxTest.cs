using TDDdemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for BoxTest and is intended
    ///to contain all BoxTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BoxTest
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
        ///A test for Push
        ///</summary>
        [TestMethod()]
        public void PushTest()
        {
            Box target = new Box(); // TODO: Initialize to an appropriate value
            string taskName = string.Empty; // TODO: Initialize to an appropriate value
            int priority = 0; // TODO: Initialize to an appropriate value
            target.Push(taskName, priority);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Push
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TDDdemo.exe")]
        public void PushTest1()
        {
            Box_Accessor target = new Box_Accessor(); // TODO: Initialize to an appropriate value
            
            string taskName = string.Empty; // TODO: Initialize to an appropriate value
            int priority = 0; // TODO: Initialize to an appropriate value
            target.Push(taskName, priority);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
