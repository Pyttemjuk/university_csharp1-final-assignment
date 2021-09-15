using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /// <summary>
    /// Class that handles a list of loan objects with methods to add, change and delete loans
    /// </summary>
    class LoanManager
    {
        private List<Loan> loanList;

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoanManager() 
        {
            loanList = new List<Loan>();
        }

        /// <summary>
        /// Get number of loans currently in the list
        /// </summary>
        public int Count
        {
            get { return loanList.Count; }
        }

        /// <summary>
        /// Adds a loan to the loan list
        /// </summary>
        /// <param name="loan"></param>
        /// <returns></returns>
        public bool AddLoan(Loan loan)
        {
            //Check variable
            bool ok = loan != null;

            if (ok)
                loanList.Add(loan);

            return ok;
        }

        /// <summary>
        /// Handles changing the return date for a loan in the loan list
        /// </summary>
        /// <param name="date"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeLoanDate(DateTime date, int index)
        {
            bool ok = index >= 0 && index < Count;

            if (ok)
            {
                loanList[index].ReturnDate = date;
            }

            return ok;
        }

        /// <summary>
        /// Deletes a loan from the loan list
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteLoan(int index)
        {
            //Check variable
            bool ok = index >= 0 && index < Count;

            if (ok)
                loanList.RemoveAt(index);

            return ok;
        }

        /// <summary>
        /// Gets a loan from the loan list
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Loan GetLoan(int index)
        {
            if (index < 0 || index >= loanList.Count)
                return null;

            return loanList[index];
        }

        /// <summary>
        /// Gets loan information about all the loan in the loan list as strings
        /// </summary>
        /// <returns></returns>
        public string[] GetLoanInfo()
        {
            string[] strLoanInfo = new string[loanList.Count];

            int index = 0;
            foreach (Loan loanObj in loanList)
                strLoanInfo[index++] = loanObj.ToString();

            return strLoanInfo;
        }
    }
}
