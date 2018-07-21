using System;
using System.Collections.Generic;
using System.Text;

namespace csGenerator
{

    public static class g
    {
        public const int LAYERS = 9;
        public const int SIZE = 9;
        public const int N_SET_QUADS = 5;

        public static void PrintPuzzle(cPuzzle puzzle)
        {
            Console.WriteLine(puzzle.DisplayString());
            Console.Write("Press Any Key: ");
            Console.ReadKey();
            Console.WriteLine();
        }

    }
}
