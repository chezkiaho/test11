using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class BankBranch
    {
        private int branchID;
            
        public int BranchID
        {
            get { return branchID; }
            set { branchID = value; }
        }


        private int bankCode;

        public int BankCode
        {
            get { return bankCode; }
            set { bankCode = value; }
        }

        private string bankName;

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }
        private int branchCode;

        public int BranchCode
        {
            get { return branchCode; }
            set { branchCode = value; }
        }

        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        private int xCoordinate;

        public int XCoordinate
        {
            get { return xCoordinate; }
            set { xCoordinate = value; }
        }
        private int yCoordinate;

        public int YCoordinate
        {
            get { return yCoordinate; }
            set { yCoordinate = value; }
        }

        //private string branchCiti; //  not need becouse is in address struct

        //public string BranchCiti
        //{
        //    get { return branchCiti; }
        //    set { branchCiti = value; }
        //}

    }
}
