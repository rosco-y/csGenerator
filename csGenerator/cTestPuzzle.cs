using System;
using System.Collections.Generic;
using System.Text;
using csGenerator.Model;
using csGenerator;

namespace csGenerator
{
        
    class cTestPuzzle
    {
        cPuzzle _puzzle;

        public cTestPuzzle()
        {
            _puzzle = new cPuzzle();
        }

        public void PrintPuzzle()
        {
            Console.WriteLine(_puzzle.DisplayString());
            Console.Write("Press Any Key: ");
            Console.ReadKey();
            Console.WriteLine();
        }

        public void TestLoop()
        {
            for (int i = 1; i<= g.SIZE; i++)
            {
                PrintPuzzle();
                RemoveAllExcept(i);
            }
        }


        /// <summary>
        /// DEBUG: I expected grids of 0,1,2,3,4,5,6,7,8, and 9. What's not working?
        /// </summary>
        /// <param name="except"></param>
        public void RemoveAllExcept(int except)
        {
            for (int r = 0; r < g.SIZE; r++)
            {
                for (int c = 0; c < g.SIZE; c++)
                {
                    for(int i= 1; i <= g.SIZE; i++)
                    {
                        if (i != except)
                        {
                            _puzzle.Grid[r][c].Remove(i);
                        }
                    }

                }

            }
        }
    }
}
