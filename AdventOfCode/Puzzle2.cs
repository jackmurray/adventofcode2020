using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Puzzle2 : Puzzle1
    {
        public override int Run()
        {
            foreach (int i in ParsedData)
            {
                foreach (int j in ParsedData)
                {
                    foreach (int k in ParsedData)
                    {
                        if (i + j + k == SUM_TARGET)
                            return (i * j * k);
                    }
                }
            }

            throw new ArgumentException("No trio of inputs summed to " + SUM_TARGET);
        }
    }
}
