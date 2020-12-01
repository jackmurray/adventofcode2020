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
            foreach (int i in Data)
            {
                foreach (int j in Data)
                {
                    foreach (int k in Data)
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
