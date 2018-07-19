using System;

namespace csGenerator
{
    class cMain
    {
        static void Main(string[] args)
        {
            try
            {
                cTestPuzzle test = new cTestPuzzle();
                test.TestLoop();
                Console.Write("Done. Press Any Key: ");
                Console.ReadKey();
            }
            catch (Exception X)
            {
                Console.WriteLine(X.Message);
                Console.ReadKey();
            }
        }

    }
}
