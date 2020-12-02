using System;
using System.Collections.Generic;
using AdventOfCode;

namespace AdventOfCode.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            IPuzzle p;
            List<string> input = new();

            int puzzleNumber = int.Parse(args[0]);

            switch (puzzleNumber)
            {
                case 1:
                    p = new Puzzle1();
                    break;
                case 2:
                    p = new Puzzle2();
                    break;
                default:
                    throw new ArgumentException("Invalid puzzle number");
            }

            Console.WriteLine("Paste puzzle input now, with a blank line to finish:");

            string consoleInput;
            while (true)
            {
                consoleInput = Console.ReadLine();
                if (string.IsNullOrEmpty(consoleInput))
                    break;

                input.Add(consoleInput);
            }

            p.Input(input);
            Console.WriteLine($"Puzzle solved: {p.Run()}");
        }
    }
}
