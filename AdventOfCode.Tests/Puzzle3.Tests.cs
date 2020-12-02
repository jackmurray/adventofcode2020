using NUnit.Framework;
using System.Collections.Generic;

namespace AdventOfCode.Tests
{
    public class Puzzle3Tests
    {
        private IEnumerable<string> TestData;
        private IPuzzle p;

        [SetUp]
        public void Setup()
        {
            TestData = TestHelper.LoadInputFromFile("puzzle3.txt");
            p = new Puzzle3();
            p.Input(TestData);
        }


        [Test]
        public void Test1()
        {
            Assert.AreEqual(2, p.Run());
        }
    }
}