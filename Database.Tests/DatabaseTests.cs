using Microsoft.VisualStudio.TestTools.UnitTesting;

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
