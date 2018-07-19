using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace csGenerator.Model
{

    public class cCandidate
    {
        #region -------------------------------------- PRIVATE MEMBERS -----------------------------------
        List<int> _candidates;
        const int NUM_CANDIDATES = 9;
        #endregion ----------------------------------- PRIVATE MEMBERS -----------------------------------

        #region -------------------------------------- PUBLIC MEMBERS ------------------------------------
        public int FinalValue { get; private set; } = 0;
        #endregion ----------------------------------- PUBLIC MEMBERS -----------------------------------

        #region --------------------------------------- CONSTRUCTION ------------------------------------
        public cCandidate()
        {
            _candidates = new List<int>();
            RefillCandidates();

        }

        ~cCandidate()
        {
            _candidates?.Clear();
            _candidates = null;
        }
        #endregion -------------------------------- CONSTRUCTION ----------------------------------------

        #region ----------------------------------- PRIVATE ACCESS --------------------------------------

        bool CandidateFound(int candidate)
        {

            return _candidates.Contains(candidate);
        }
        #endregion ----------------------------------- PRIVATE ACCESS --------------------------------------

        #region ----------------------------------- PUBLIC  ACCESS -----------------------------------------
        public void RefillCandidates()
        {
            _candidates.Clear();
            //populate candidates with 1 through NUM_CANDIDATES;
            for (int candidate = 1; candidate <= NUM_CANDIDATES; candidate++)
            {
                if (!_candidates.Contains(candidate))
                    _candidates.Add(candidate);
            }
        }

        public bool Remove(int candidate)
        {
            bool removed = false;

            // TODO: 'while loop feels like overkill here: when would there be more than 1 of each candidate?        
            /// if there are only two candidates
            /// ie  1, 2
            /// and '2' is removed. then the finalValue must be 1.
            try
            {
                if (_candidates.Contains(candidate))
                {
                    if (_candidates.Count > 2 && _candidates.Count != 2)
                    {
                        // if one removal was successful.
                        removed = _candidates.Remove(candidate);
                    }
                    else
                    {
                        /// assigning the result of _candidates.Remove() to removed, 
                        /// and testing this result.
                        if (removed = _candidates.Remove(candidate))
                        {
                            FinalValue = _candidates[0]; //.FindIndex(0);
                        }
                    }
                }

            }
            catch (Exception x)
            {
                string msg = $"cCandidate.Remove({candidate}).  _candidates.Count = {_candidates.Count}" + Environment.NewLine
                    + $"{x.Message}";
                throw new Exception(msg);
            }
            return removed;
        }

        /// <summary>
        /// count of candidates.  if zero, _finameValue must be set.
        /// </summary>
        public int Count
        {
            get
            {
                int count = _candidates.Count;
                if (count == 0 && FinalValue == 0)
                {
                    string msg = "cCandidate.Count" + Environment.NewLine +
                    $"Count = {count} and finalValue = {FinalValue}" + Environment.NewLine +
                    "Final Value must be set when Candidates Count == 0.";
                    throw new Exception(msg);
                }
                return _candidates.Count;
            }
        }



        #endregion ----------------------------------- PUBLIC  ACCESS --------------------------------------
    }// END CLASS csCandidate

} // END NAMESPACE csGenerator.Model
