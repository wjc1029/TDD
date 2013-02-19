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
        ///A test for Push: verify push count
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TDDdemo.exe")]
        public void PushTest()
        {
            Box_Accessor target = new Box_Accessor(); // TODO: Initialize to an appropriate value
            int i = target.Count();
            target.Push("a", 10);
            int j = target.Count();
            Assert.AreEqual(j, i + 1);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Push: verify push twice count
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TDDdemo.exe")]
        public void PushTest2()
        {
            Box_Accessor target = new Box_Accessor(); // TODO: Initialize to an appropriate value
            int i = target.Count();
            target.Push("a", 10);
            target.Push("b", 20);
            int j = target.Count();
            Assert.AreEqual(j, i + 2);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Push: verify push content
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TDDdemo.exe")]
        public void PushTest3()
        {
            Box_Accessor target = new Box_Accessor(); // TODO: Initialize to an appropriate value
            string key = "a";
            int pri = 10;

            target.Push(key, pri);
            bool hasA = target.tasks.ContainsKey(key);
            Assert.AreEqual(true, hasA);
            int expected_pri = pri;
            int actual_pri = target.tasks[key];
            Assert.AreEqual(expected_pri, actual_pri);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Push: verify push twice content
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TDDdemo.exe")]
        public void PushTest4()
        {
            Box_Accessor target = new Box_Accessor(); // TODO: Initialize to an appropriate value
            string key1 = "a";
            int pri1 = 10;
            string key2 = "b";
            int pri2 = 20;

            target.Push(key1, pri1);
            target.Push(key2, pri2);

            bool hasA = target.tasks.ContainsKey(key1);
            Assert.AreEqual(true, hasA);
            int expected_pri1 = pri1;
            int actual_pri1 = target.tasks[key1];
            Assert.AreEqual(expected_pri1, actual_pri1);

            bool hasB = target.tasks.ContainsKey(key2);
            Assert.AreEqual(true, hasB);
            int expected_pri2 = pri2;
            int actual_pri2 = target.tasks[key2];
            Assert.AreEqual(expected_pri2, actual_pri2);

            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }


        /// <summary>
        ///A test for Push: verify push same task twice
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TDDdemo.exe")]
        public void PushTest5()
        {
            Box_Accessor target = new Box_Accessor(); // TODO: Initialize to an appropriate value
            string key1 = "a";
            int pri1 = 10;
            string key2 = "a";
            int pri2 = 10;

            target.Push(key1, pri1);
            target.Push(key2, pri2);

            bool hasA = target.tasks.ContainsKey(key1);
            Assert.AreEqual(true, hasA);
            int expected_pri1 = pri1;
            int actual_pri1 = target.tasks[key1];
            Assert.AreEqual(expected_pri1, actual_pri1);

            bool hasB = target.tasks.ContainsKey(key2);
            Assert.AreEqual(true, hasB);
            int expected_pri2 = pri2;
            int actual_pri2 = target.tasks[key2];
            Assert.AreEqual(expected_pri2, actual_pri2);

            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Push: verify push 1000 times
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TDDdemo.exe")]
        public void PushTest6()
        {
            Box_Accessor target = new Box_Accessor(); // TODO: Initialize to an appropriate value
            int numpush = 1000;
            for(int i=0; i<numpush; i++)
            {
                target.Push("a"+i.ToString(), i);
            }

            bool hasKey = target.tasks.ContainsKey("a"+(numpush-1).ToString());
            Assert.AreEqual(true, hasKey);
            int expected_pri = numpush-1;
            int actual_pri = target.tasks["a"+(numpush-1).ToString()];
            Assert.AreEqual(expected_pri, actual_pri);

            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Push: verify empty task name
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TDDdemo.exe")]
        public void PushTest7()
        {
            Box_Accessor target = new Box_Accessor(); // TODO: Initialize to an appropriate value
            string task = "";
            int pri = 10;

            target.Push(task, pri);
            bool hasKey = target.tasks.ContainsKey(task);
            Assert.AreEqual(false, hasKey);

            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Push: verify blank task name
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TDDdemo.exe")]
        public void PushTest8()
        {
            Box_Accessor target = new Box_Accessor(); // TODO: Initialize to an appropriate value
            string task = " ";
            int pri = 10;

            target.Push(task, pri);
            bool hasKey = target.tasks.ContainsKey(task);
            Assert.AreEqual(false, hasKey);

            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Push: verify negative priority
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TDDdemo.exe")]
        public void PushTest9()
        {
            Box_Accessor target = new Box_Accessor(); // TODO: Initialize to an appropriate value
            string task = "a";
            int pri = -1;

            target.Push(task, pri);
            bool hasKey = target.tasks.ContainsKey(task);
            Assert.AreEqual(false, hasKey);

            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Pop
        ///</summary>
        [TestMethod()]
        public void PopTest()
        {
            
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for List
        ///</summary>
        [TestMethod()]
        public void ListTest()
        {

            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
        
    }
}
