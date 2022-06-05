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
        Movie newMovie = new Movie() { Id = 1, Name = "Reservoir Dogs", Country = "America", LengthInMinutes = 99 };
        [TestMethod()]
        public void ConvertLengthInMinutesToSecondsTestValid()
        {
            Assert.AreEqual(5940, newMovie.ConvertLengthInMinutesToSeconds());
        }
        [TestMethod()]
        public void ConstructorTest()
        {
            Assert.AreEqual(1, newMovie.Id);
            Assert.AreEqual("Reservoir Dogs", newMovie.Name);
            Assert.AreEqual("America", newMovie.Country);
            Assert.AreEqual(99, newMovie.LengthInMinutes);
        }
        [TestMethod()]
        public void ConvertLengthInMinutesToSecondsTestInvalid()
        {
            newMovie.LengthInMinutes = 0;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => newMovie.ConvertLengthInMinutesToSeconds());
            newMovie.LengthInMinutes = -1;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => newMovie.ConvertLengthInMinutesToSeconds());
        }
    }
}