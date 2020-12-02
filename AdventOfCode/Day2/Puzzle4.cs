using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Puzzle3 : PuzzleBase
    {
        public override int Run()
        {
            return this.Data.Count(d => this.IsValidPassword(d));
        }

        private bool IsValidPassword(string d)
        {
            string[] split = d.Split(' ');
            string[] minMaxValues = split[0].Split('-');

            int minOccurrences = int.Parse(minMaxValues[0]);
            int maxOccurrences = int.Parse(minMaxValues[1]);

            char requiredChar = split[1][0]; // the first char is the thing we care about, the second will be the colon after it.

            string password = split[2];

            int actualOccurrences = password.Count(c => c == requiredChar);

            // if we didn't have enough, or had too many, then reject.
            if (actualOccurrences < minOccurrences || actualOccurrences > maxOccurrences)
                return false;

            return true;
        }
    }
}
