using System;
using System.Collections.Generic;
using System.Text;
using csGenerator;

namespace csGenerator.Model
{
    class cCell
    {

        #region -----------------------------------vvv PRIVATE MEMBERS vvv--------------------------------
        cCandidate _candidates;
        #endregion --------------------------------^^^ PRIVATE MEMBERS ^^^--------------------------------

        #region -----------------------------------vvv PUBLIC MEMBERS vvv---------------------------------
        #endregion --------------------------------^^^ PUBLIC MEMBERS ^^^---------------------------------

        #region ------------------------------------vvv CONSTRUCTION vvv----------------------------------
        public cCell()
        {
            _candidates = new cCandidate();
        }

        ~cCell()
        {
            _candidates = null;
        }
        #endregion----------------------------------^^^ CONSTRUCTION ^^^----------------------------------

        #region -----------------------------------vvv PRIVATE ACCESS vvv---------------------------------
        
        #endregion --------------------------------^^^ PRIVATE ACCESS ^^^---------------------------------

        #region ------------------------------------vvv PUBLIC ACCESS vvv---------------------------------
        public int FinalValue
        {
            get { return _candidates.FinalValue; }
        }

        public bool Remove(int value)
        {
            return _candidates.Remove(value);
        }
        #endregion ---------------------------------^^^ PUBLIC ACCESS ^^^---------------------------------

    } // END CLASS cCell

} // END NAMESPACESS csGenerator.Model
