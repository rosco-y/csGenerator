using System;
using System.Collections.Generic;
using System.Text;
using csGenerator.Model;
using csGenerator;
namespace csGenerator
{
    public class cPuzzle
    {
        #region -------------------------------------- PRIVATE MEMBERS -----------------------------------
        //int[,,] _grid;
        cCell[][] _grid;
        //int[,,,] _row;
        //int[,,,] _col;
        //int[,,,] _box;
        //int[,,] _solved;
        //int[,,] _puzzle;
        //int[,] _r_1;
        //int[,] _c_1;
        #endregion ----------------------------------- PRIVATE MEMBERS -----------------------------------

        #region -------------------------------------- PUBLIC MEMBERS ------------------------------------
        #endregion ----------------------------------- PUBLIC MEMBERS ------------------------------------

        #region --------------------------------------- CONSTRUCTION -------------------------------------
        public cPuzzle()
        {
            //
            //constructArrays();
            _grid = new cCell[g.SIZE][];
            for(int r = 0; r < g.SIZE; r++)
            {
                _grid[r] = new cCell[g.SIZE];
                for (int c =0; c < g.SIZE; c++)
                {
                    _grid[r][c] = new cCell();
                }
            }
        }

        void constructArrays()
        {
            ////_grid = new int[g.LAYERS, g.SIZE, g.SIZE];
            //_row = new int[g.LAYERS, g.SIZE, g.SIZE, 2];
            //_col = new int[g.LAYERS, g.SIZE, g.SIZE, 2];
            //_box = new int[g.LAYERS, g.SIZE, g.SIZE, 2];
            //_solved = new int[g.LAYERS, g.SIZE, g.SIZE];
            //_puzzle = new int[g.LAYERS, g.SIZE, g.SIZE];
            //_r_1 = new int[g.LAYERS, g.SIZE * g.SIZE];
            //_c_1 = new int[g.LAYERS, g.SIZE * g.SIZE];
        }
        #endregion------------------------------------- CONSTRUCTION -------------------------------------

        #region -------------------------------------- PRIVATE ACCESS ------------------------------------
        public string DisplayString()
        {
            StringBuilder sbGrid = new StringBuilder();

            
            string diviser = Environment.NewLine + new string('-', 29) + Environment.NewLine;
            string sWriteLine = diviser + " | ";
            for (int r = 0; r < g.SIZE; r++)
            {
                //if ((r + 1) % 3 == 0)
                for (int c = 0; c < g.SIZE; c++)
                {
                    sWriteLine += $"{_grid[r][c].FinalValue} ";
                        if ((c + 1) % 3 == 0)
                            sWriteLine += " | ";
                    }
                if ((r + 1) % 3 == 0)
                    sWriteLine += Environment.NewLine + diviser;

                //sWriteLine += diviser;
                sbGrid.Append($"{sWriteLine}");
                sWriteLine = Environment.NewLine + " | ";

            }
            return sbGrid.ToString();
        }

        public cCell[][] Grid
        {
            get { return _grid; }
            set { _grid = value; }
        }
        #endregion ----------------------------------- PRIVATE ACCESS ------------------------------------

        #region --------------------------------------- PUBLIC ACCESS ------------------------------------
        #endregion ------------------------------------ PUBLIC ACCESS ------------------------------------
    }
}
