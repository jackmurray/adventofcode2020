using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public abstract class PuzzleBase : IPuzzle
    {
        protected IEnumerable<int> Data;

        public virtual void Input(IEnumerable<int> Data)
        {
            this.Data = Data;
        }

        public abstract int Run();
    }
}
