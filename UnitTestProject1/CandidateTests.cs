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


        #region TEST METHODS


        /// <summary>
        /// The CandidateRemovalTest verifies that the the cCandidate.Remove() function
        /// actually removes what it is supposed to.
        /// 
        /// It does this by ensuring that each cell in the 9x9 puzzle grid contains all
        /// candidates (1-9), and then removes all of the candidates except for a value 
        /// N (the loopN variable), and then each cell should contains only one candidate,
        /// "loopN", and the sum of all of the cells in the grid should be 81 * loopN.
        /// (9 x 9 x loopN).
        /// </summary>
        [TestMethod]
        public void CandidateRemoveTest()
        {
            _puzzle = new cPuzzle();
            for (int loopN = 1; loopN <= g.SIZE; loopN++)
            {
                for (int r = 0; r < g.SIZE; r++)
                {
                    for (int c = 0; c < g.SIZE; c++)
                    {
                        _puzzle.Grid[r][c].RefillCandidates();
                        Assert.AreEqual(sumOfCellCandidate(_puzzle.Grid[r][c]), 45, "Cell Candidates were not correctly refilled");
                    }
                }
                RemoveAllExcept(loopN);
                Assert.AreEqual(81 * loopN, SumOfCandidates(), "Incorrect Candidate Sum.");
                
            }
        }
        
        [TestMethod]
        public void TestFullCandidateValues()
        {
            _puzzle = new cPuzzle();
            for (int row = 0; row < g.SIZE; row++)
            {
                for (int col = 0; col < g.SIZE; col++)
                {
                    Assert.AreEqual(sumOfCellCandidate(_puzzle.Grid[row][col]), 45, "Cell Candidates were not correctly refilled");
                }
            }
        }
        #endregion

        #region HELPER FUNCTIONS

        int sumOfCellCandidate(cCell cell)
        {
            int sum = 0;
            foreach (int val in cell.Candidates)
            {
                sum += val;
            }
            return sum;
        }


        int SumOfCandidates()
        {
            int sum = 0;
            for (int row = 0; row < g.SIZE; row++)
            {
                for (int col = 0; col < g.SIZE; col++)
                {
                    sum += _puzzle.Grid[row][col].Solution;
                }

            }
            return sum;
        }


        /// <summary>
        /// DEBUG: I expected grids of 0,1,2,3,4,5,6,7,8, and 9. What's not working?
        /// </summary>
        /// <param name="loop"></param>
        public void RemoveAllExcept(int loop)
        {
            for (int row = 0; row < g.SIZE; row++)
            {
                for (int col = 0; col < g.SIZE; col++)
                {
                    for (int i = 1; i <= g.SIZE; i++)
                    {
                        if (i != loop)
                        {
                            _puzzle.Grid[row][col].RemoveCandidate(i);
                        }
                    }

                }

            }
        }
        #endregion

    }
}
