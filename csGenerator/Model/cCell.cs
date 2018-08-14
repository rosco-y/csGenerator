using System;
using System.Collections.Generic;
using System.Text;
using csGenerator;

namespace csGenerator.Model
{
    public class cCell
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
        public void RefillCandidates()
        {
            _candidates.RefillCandidates();
        }

        public int Solution
        {
            get { return _candidates.Solution; }
        }

        public bool RemoveCandidate(int value)
        {
            return _candidates.Remove(value);
        }

       public List<int> Candidates
        {
            get { return _candidates.Candidates; }
        }
        #endregion ---------------------------------^^^ PUBLIC ACCESS ^^^---------------------------------

    } // END CLASS cCell

} // END NAMESPACESS csGenerator.Model
