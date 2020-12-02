using NUnit.Framework;
using System.Collections.Generic;

namespace AdventOfCode.Tests
{
    public class Tests
    {
        private IEnumerable<string> TestData;
        private IPuzzle p;

        [SetUp]
        public void Setup()
        {
            TestData = TestHelper.LoadInputFromFile("puzzle1.txt");
            p = new Puzzle1();
            p.Input(TestData);
        }


        [Test]
        public void Test1()
        {
            Assert.AreEqual(514579, p.Run());
        }
    }
}