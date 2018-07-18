using System;

namespace csGenerator
{
    class cMain
    {
        static void Main(string[] args)
        {

            createPuzzle();
            Console.Write("Done. Press Any Key: ");
            Console.ReadKey();
        }

        static void createPuzzle()
        {
            cPuzzle puzzle = new cPuzzle();
            Console.WriteLine(puzzle.DisplayString());
        }
    }
}
