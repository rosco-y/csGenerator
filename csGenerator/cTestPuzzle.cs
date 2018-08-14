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

       

        public void TestLoop()
        {
            for (int i = 1; i<= g.SIZE; i++)
            {
                for (int r = 0; r < g.SIZE; r++)
                {
                    for (int c = 0; c < g.SIZE; c++)
                    {
                        // ensure each cell in the puzzle contains candidates 1-9
                        _puzzle.Grid[r][c].RefillCandidates();
                    }
                }
                RemoveAllExcept(i);
                g.PrintPuzzle(_puzzle);
            }
        }



        /// <summary>
        /// Remove all of each cells candidates except for the value
        /// of the passed argument:
        /// pre:
        ///     all cells contain at least the cell to be removed, and
        ///     possibliy all values 1-9.
        /// post:
        ///     all cells contain only 1 candidate, which is the value
        ///     of the passed argument.
        /// </summary>
        /// <param name="dontRemoveThisCandidate">the value of the candidate to
        /// be preserved in each cell.
        /// </param>
        public void RemoveAllExcept(int dontRemoveThisCandidate)
        {
            for (int r = 0; r < g.SIZE; r++)
            {
                for (int c = 0; c < g.SIZE; c++)
                {
                    for(int i= 1; i <= g.SIZE; i++)
                    {
                        if (i != dontRemoveThisCandidate)
                        {
                            _puzzle.Grid[r][c].RemoveCandidate(i);
                        }
                    }

                }

            }
        }
    }
}
