using System;
using System.Collections.Generic;
using System.Text;

namespace csGenerator
{
    /// <summary>
    /// cStrategies is a class exlusively intended to record and relay the
    /// kinds of strategies used to solve a puzzle.
    /// i.e.
    ///     Level 0 Strategies:
    ///         Naked_Single
    ///         Strategy_Unique
    ///         Stategy_Cleanup
    ///     Level 1 Strategies:
    ///         Naked_Pair
    ///         Hidden_Pair
    ///         Box_Line
    ///         Pointing_Line
    ///     Level 2 Strategies:
    ///         Naked_Triple
    ///         Naked_Quad
    ///         Hidden_Triple
    ///         X_Wing
    ///         Y_Wing
    ///     Level 3 Strategies:
    ///         XY_Chain
    ///         Rectangle
    ///         Lines_3
    ///         Lines_4
    ///     Leven 4 Strategy:
    ///         Backtracking
    ///         fin.
    ///         
    /// The point is, it is interesting to preserve the kinds of strategies required to solve a puzzle,
    /// as this is an accurate way to determine the difficulty of a puzzle.  So, as each strategy is 
    /// required to solve a puzzle, it is noted in this cStragies class, which then can be saved to the
    /// database with the puzzle itself.
    /// to
    /////////////////////////////////////////////////////////////////////////////////////////////////    
    public class cStrategies
    {

        #region -----------------------------------vvv PRIVATE MEMBERS vvv--------------------------------


        #endregion --------------------------------^^^ PRIVATE MEMBERS ^^^--------------------------------

        #region -----------------------------------vvv PUBLIC MEMBERS (with backing members) vvv----------
        // LEVEL 0
        public bool NakedSingle { get; set; } = false;
        public bool StrategyUnique { get; set; } = false;
        public bool StrategyCleanup { get; set; } = false;
        // LEVEL 1
        public bool NakedPair { get; set; } = false;
        public bool HiddenPair { get; set; } = false;
        public bool BoxLine  { get; set; } = false;
        public bool PointingLine  { get; set; } = false;
        // LEVEL 2
        public bool NakedTriple  { get; set; } = false;
        public bool NakedQuad  { get; set; } = false;
        public bool X_Wing  { get; set; } = false;
        public bool Y_Wing  { get; set; } = false;
        // LEVEL 3
        public bool XY_Chain  { get; set; } = false;
        public bool Rectagle  { get; set; } = false;
        public bool Lines_3  { get; set; } = false;
        public bool Lines_4  { get; set; } = false;
        // LEVEL 4
        public bool BackTracking  { get; set; } = false;

        #endregion --------------------------------^^^ PUBLIC MEMBERS ^^^---------------------------------
        #region UNUSED REGIONS

        #region ------------------------------------vvv CONSTRUCTION vvv----------------------------------
        #endregion----------------------------------^^^ CONSTRUCTION ^^^----------------------------------

        #region -----------------------------------vvv PRIVATE ACCESS vvv---------------------------------
        #endregion --------------------------------^^^ PRIVATE ACCESS ^^^---------------------------------

        #region ------------------------------------vvv PUBLIC ACCESS vvv---------------------------------

        #endregion ---------------------------------^^^ PUBLIC ACCESS ^^^---------------------------------
        #endregion UNUSED REGIONS
    }  // END CLASS
}
