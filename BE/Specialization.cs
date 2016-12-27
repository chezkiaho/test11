using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
  public  class Specialization
    {
        public enum fieldEnum 
        {
            dataBases, communication, dataSecurity, serverSide, mobile, guiDesign
        };
        private fieldEnum field;
        public fieldEnum Field
        {
            get { return field; }
            set { field = value; }
        }

        private int specialtyNum;
        public int SpecialtyNum
        {
            get { return specialtyNum; }
            set { specialtyNum = value; } 
        }

        private string specialtyName;
        public string SpecialtyName
        {
            get { return specialtyName; }
            set { specialtyName = value; }
        }

        private float minPayment;
        public float MinPayment
        {
            get { return minPayment; }
            set { minPayment = value; }
        }

        private float maxPayment;
        public float MaxPayment
        {
            get { return maxPayment; }
            set { maxPayment = value; }
        }

        
        //functions.
        public override string ToString()
        {
            string tmp = SpecialtyName + ", " + "specialty number " + SpecialtyNum + ", minimum pament rate is: " + MinPayment + " NIS, " + "and maximum payment is: " + MaxPayment;
            return tmp;
        }
    }
}
