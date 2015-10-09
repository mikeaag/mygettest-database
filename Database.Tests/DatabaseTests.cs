using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlanBlunden.Database;

namespace AlanBlunden.Database.Tests
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void TestTYPEReturnsSQL()
        {
            Assert.AreEqual("SQL", Database.TYPE);
        }
    }
}
