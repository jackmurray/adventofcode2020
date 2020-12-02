using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Puzzle4 : PuzzleBase
    {
        public override int Run()
        {
            return this.Data.Count(d => this.IsValidPassword(d));
        }

        private bool IsValidPassword(string d)
        {
            string[] split = d.Split(' ');
            string[] minMaxValues = split[0].Split('-');

            int firstIndex = int.Parse(minMaxValues[0]) - 1; // the indices in the input are based at 1, not 0.
            int secondIndex = int.Parse(minMaxValues[1]) - 1;

            char requiredChar = split[1][0]; // the first char is the thing we care about, the second will be the colon after it.

            string password = split[2];

            bool firstIndexMatches = password[firstIndex] == requiredChar;
            bool secondIndexMatches = password[secondIndex] == requiredChar;

            return firstIndexMatches ^ secondIndexMatches; // xor the results - we need exactly one of the chars to match.
        }
    }
}
