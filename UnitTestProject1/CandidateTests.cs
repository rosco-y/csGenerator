using Microsoft.VisualStudio.TestTools.UnitTesting;
using csGenerator;
using csGenerator.Model;
using System.IO;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class CandidateTests
    {

        cPuzzle _puzzle;

        [TestMethod]
        public void CandidateSums()
        {
            _puzzle = new cPuzzle();
            for (int i = 1; i <= g.SIZE; i++)
            {
                for (int r = 0; r < g.SIZE; r++)
                {
                    for (int c = 0; c < g.SIZE; c++)
                    {
                        _puzzle.Grid[r][c].RefillCandidates();

                    }

                }
                RemoveAllExcept(i);
                Assert.AreEqual(81 * i, CandidateSum(), "Incorrect Candidate Sum.");
                
            }
        }
        

        int CandidateSum()
        {
            int sum = 0;
            for (int r = 0; r < g.SIZE; r++)
            {
                for (int c = 0; c < g.SIZE; c++)
                {
                    sum += _puzzle.Grid[r][c].FinalValue;

                }

            }
            return sum;
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
                    for (int i = 1; i <= g.SIZE; i++)
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
