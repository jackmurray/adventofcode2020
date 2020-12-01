using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Tests
{
    public class TestHelper
    {
        public static IEnumerable<int> LoadInputFromFile(string path)
        {
            var lines = System.IO.File.ReadAllLines("..\\..\\..\\ExampleInputs\\" + path);
            foreach (var line in lines)
            {
                yield return int.Parse(line);
            }
        }
    }
}
