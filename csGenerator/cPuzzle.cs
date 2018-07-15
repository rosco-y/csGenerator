using System;
using System.Collections.Generic;
using System.Text;

namespace csGenerator
{
    class cPuzzle
    {
        #region PRIVATE MEMBERS
        int[,,] _grid;
        int[,,,] _row;
        int[,,,] _col;
        int[,,,] _box;
        int[,,] _solved;
        int[,,] _puzzle;
        int[,] _r_1;
        int[,] _c_1;

        #endregion PRIVATE MEMBERS

        #region public MEMBERS
        #endregion public MEMBERS

        #region Construction
        public cPuzzle()
        {
            //
            constructArrays();
        }

        /// <summary>
        /// Need to use the new operator to constuct the arrays.
        /// Arrays are proper sized, filled with zeros.
        /// </summary>
        void constructArrays()
        {
            _grid = new int[g.LAYERS,g.SIZE,g.SIZE];
            _row = new int[g.LAYERS, g.SIZE, g.SIZE, 2];
            _col  = new int[g.LAYERS, g.SIZE, g.SIZE, 2];
            _box = new int[g.LAYERS, g.SIZE, g.SIZE, 2];
            _solved = new int[g.LAYERS, g.SIZE, g.SIZE];
            _puzzle = new int[g.LAYERS, g.SIZE, g.SIZE];
            _r_1 = new int[g.LAYERS, g.SIZE * g.SIZE];
            _c_1 = new int[g.LAYERS, g.SIZE * g.SIZE];
        }

        #endregion Construction

        #region PRIVATE METHODS
        #endregion PRIVATE METHODS

        #region PUBLIC METHODS

        #endregion PUBLIC METHODS
    }
}
