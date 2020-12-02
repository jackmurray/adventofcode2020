using System;

namespace AdventOfCode
{
    public class Puzzle1 : PuzzleBaseInt
    {
        protected const int SUM_TARGET = 2020;

        public override int Run()
        {
            foreach (int i in ParsedData)
            {
                foreach (int j in ParsedData)
                {
                    if (i + j == SUM_TARGET)
                        return (i * j);
                }
            }

            throw new ArgumentException("No pair of inputs summed to " + SUM_TARGET);
        }
    }
}
