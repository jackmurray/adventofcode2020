using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public abstract class PuzzleBaseInt : PuzzleBase
    {
        protected IEnumerable<int> ParsedData;

        public override void Input(IEnumerable<string> Data)
        {
            var newList = new List<int>();
            foreach (string s in Data)
            {
                newList.Add(int.Parse(s));
            }

            this.ParsedData = newList;
        }
    }
}
