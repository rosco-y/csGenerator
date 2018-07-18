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
            refillCandidates();

        }

        ~cCandidate()
        {
            _candidates?.Clear();
            _candidates = null;
        }
        #endregion -------------------------------- CONSTRUCTION ----------------------------------------

        #region ----------------------------------- PRIVATE ACCESS --------------------------------------
        void refillCandidates()
        {
            _candidates.Clear();
            //populate candidates with 1 through NUM_CANDIDATES;
            for (int candidate = 1; candidate <= NUM_CANDIDATES; candidate++)
            {
                _candidates.Add(candidate);
            }
        }

        bool CandidateFound(int candidate)
        {

            return _candidates.Contains(candidate);
        }
        #endregion ----------------------------------- PRIVATE ACCESS --------------------------------------

        #region ----------------------------------- PUBLIC  ACCESS -----------------------------------------
        public bool Remove(int candidate)
        {
            bool removed = false;

            // TODO: 'while loop feels like overkill here: when would there be more than 1 of each candidate?
            if (_candidates.Count > 1)
            {
                // if one removal was successful.
                removed = _candidates.Remove(candidate);
            }
            else
            {
                if (_candidates.Contains(candidate))
                {
                    /// assigning the result of _candidates.Remove() to removed, 
                    /// and testing this result.
                    if (removed = _candidates.Remove(candidate))
                    {
                        FinalValue = candidate;
                    }
                }
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
