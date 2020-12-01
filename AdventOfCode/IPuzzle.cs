using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public interface IPuzzle
    {
        public void Input(IEnumerable<int> Data); // load input file
        public int Run(); // run the puzzle and produce output
    }
}
