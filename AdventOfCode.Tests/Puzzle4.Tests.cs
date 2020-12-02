using NUnit.Framework;
using System.Collections.Generic;

namespace AdventOfCode.Tests
{
    public class Puzzle4Tests
    {
        private IEnumerable<string> TestData;
        private IPuzzle p;

        [SetUp]
        public void Setup()
        {
            TestData = TestHelper.LoadInputFromFile("puzzle4.txt");
            p = new Puzzle4();
            p.Input(TestData);
        }


        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, p.Run());
        }
    }
}