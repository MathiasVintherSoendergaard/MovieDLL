using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDLL.Tests
{
    [TestClass()]
    public class MovieTests
    {
        public Movie m;
        [TestInitialize]
        public void SetUp()
        {
            m = new Movie() { Id = 1, Name = "Reservoir Dogs", Country = "America", LengthInMinutes = 99 };
        }
        [TestMethod()]
        public void ConvertLengthInMinutesToSecondsTestValid()
        {
            Assert.AreEqual(5940, m.tc.ConvertLengthInMinutesToSeconds(m.LengthInMinutes));
        }
        [TestMethod()]
        public void ConstructorTest()
        {
            Assert.AreEqual(1, m.Id);
            Assert.AreEqual("Reservoir Dogs", m.Name);
            Assert.AreEqual("America", m.Country);
            Assert.AreEqual(99, m.LengthInMinutes);
        }
        [TestMethod()]
        public void ConvertLengthInMinutesToSecondsTestInvalid()
        {
            m.LengthInMinutes = 0;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => m.tc.ConvertLengthInMinutesToSeconds(m.LengthInMinutes));
            m.LengthInMinutes = -1;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => m.tc.ConvertLengthInMinutesToSeconds(m.LengthInMinutes));
        }
    }
}