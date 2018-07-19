using System;

namespace csGenerator
{
    class cMain
    {
        static void Main(string[] args)
        {

            cTestPuzzle test = new cTestPuzzle();
            test.TestLoop();
            Console.Write("Done. Press Any Key: ");
            Console.ReadKey();
        }

    }
}
