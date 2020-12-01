using System;

namespace AdventOfCode
{
    public class Puzzle1 : PuzzleBase
    {
        protected const int SUM_TARGET = 2020;

        public override int Run()
        {
            foreach (int i in Data)
            {
                foreach (int j in Data)
                {
                    if (i + j == SUM_TARGET)
                        return (i * j);
                }
            }

            throw new ArgumentException("No pair of inputs summed to " + SUM_TARGET);
        }
    }
}
