using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BankAccount : BankBranch
    {
        
        private int accountNumber;

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

    }
}
