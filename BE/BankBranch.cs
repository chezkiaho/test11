using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BankBranch
    {
        public BankBranch(int id = 0, int bcode = 0, string bname = "", int branchkod = 0, int xcord = 0, int ycord = 0) //still temporary, and no address arg.
        {
            BranchID = id;
            BranchCode = bcode;
            BankName = bname;
            BranchCode = branchkod;
            //Address = addr;
            XCoordinate = xcord;
            YCoordinate = ycord;
        }

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
