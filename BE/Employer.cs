using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Employer
    {
        public Employer(int id = 0)
        {
            CompanyId = id;
        }

        private int? key;
        public int? Key
        {
            get { return key; }
            set { key = value; }
        }

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

        private int companyId;
        public int CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }

        private bool ltd; //beaam
        public bool Ltd
        {
            get { return ltd; }
            set { ltd = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string companyName;
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private string phoneNum;
        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        private string residenceAdress;
        public string ResidenceAdress
        {
            get { return residenceAdress; }
            set { residenceAdress = value; }
        }

        private DateTime sinceDate;
        public DateTime SinceDate
        {
            get { return sinceDate; }
            set { sinceDate = value; }
        }
        

        //functions.
        public override string ToString()
        {
            if (Ltd)
            {
                return "Employer " + LastName + " " + FirstName + ", " + CompanyName + ", company number " + CompanyId + " since " + SinceDate + ". adress is: " + residenceAdress + ", and phone number is: " + PhoneNum + ", field of work: " + Field + ".";
            }
            else
            {
               return "Employer " + LastName + " " + FirstName + ", id: " + CompanyId + " since " + SinceDate + ". adress is: " + residenceAdress + ", and phone number is: " + PhoneNum + ", field of work: " + Field + ".";
            }
        }
    }
}
